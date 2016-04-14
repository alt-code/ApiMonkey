var fs = require('fs')
var path = require('path')
var mkdirp = require('mkdirp')

var childProcess = require('child_process')
var async = require('async')
var utilities = require('./utilities.js')

var repo = process.argv[2]
var projectName = process.argv[3]
var passingDepVersions = {}
var nodeVersions = ['v0.10.0', 'v0.11.0', 'v0.12.0', 'v4.0.0', 'v5.0.0', 'v5.10.1']

utilities.initialSetup(repo, projectName)
  .spread(function (config, PROJECTS_ROOT, reportPath, baseVersion, err) {
    var projectRoot = path.join(PROJECTS_ROOT, projectName)

    if (err != null) {
      errorAndCleanup('Could not run install base version.', err)
      return
    }
    console.log('Initial setup done.')
    var obj = utilities.parsePackageJSON(baseVersion)
    if (!obj) {
      errorAndCleanup('Could not find node dependencies.', err)
      return
    }

    console.log('Parse package done.')
    var dependencies = obj.dependencies
    var devDependencies = obj.devDependencies
    var dependenciesNames = Object.keys(dependencies)
    var testCmd = utilities.modifyTestCmd(obj)
    console.log('Modify test command: ', testCmd)

    utilities.runInitialTests(baseVersion, testCmd, function (output) {
      console.log('Initial tests done.')

      var initialTestsResult = utilities.getTestResults(output)
      console.log('Initial tests results: ' + JSON.stringify(initialTestsResult))

      console.log('Testing different node versions.')

      function checkNodeVersions (i, projectRoot, dependencies, dependenciesNames, reportPath, testCmd, config, initialTestsResult, baseVersion) {
        if (i == nodeVersions.length) {
          // Get version dependencies
          map = utilities.checkForCache(projectRoot)
          console.log('Check for cache done.')
          var info = getDependencyVersions(projectRoot, dependencies, dependenciesNames, map, function (outdated, allDependencies) {
            // This will iterate over all outdated dependencies and create a sandbox to test each one.
            createSandboxAndTestDependency(0, outdated, projectRoot, reportPath, testCmd, config, initialTestsResult, baseVersion, dependencies)
          })
        } else {
          childProcess.exec('cd ' + baseVersion + '; . ~/.nvm/nvm.sh; nvm install ' + nodeVersions[i] + '; ' + testCmd, function (err, stdout, stderr) {
            var testRes = utilities.getTestResults(stdout)
            console.log('Test results with node version ' + nodeVersions[i] + ': ' + JSON.stringify(testRes))
            checkNodeVersions(i + 1, projectRoot, dependencies, dependenciesNames, reportPath, testCmd, config, initialTestsResult, baseVersion)
          })
        }
      }
      checkNodeVersions(0, projectRoot, dependencies, dependenciesNames, reportPath, testCmd, config, initialTestsResult, baseVersion)
    })
  })

function errorAndCleanup (err) {
  // utilities.removeSandbox(projectName, function () {
  console.log(err)
// })
}

function getDependencyVersions (projectRoot, dependencies, dependenciesNames, map, onDone) {
  var outdated = []
  var allDependencies = []

  async.each(dependenciesNames, function (key, callback) {
    var currentVersion = dependencies[key].replace(/[^\d.]/g, '')

    if (key in map) {
      var versions = map[key].versions

      allDependencies = utilities.addToArray(allDependencies, key, versions)

      if (currentVersion != versions[versions.length - 1]) {
        var newerVersions = utilities.getNewerVersions(versions, currentVersion)
        outdated = utilities.addToArray(outdated, key, newerVersions)
      }

      callback()
    } else {
      childProcess.exec('npm show ' + key + ' --json', function (error, stdout, stderr) {
        var pckgInfo = JSON.parse(stdout)

        allDependencies = utilities.addToArray(allDependencies, pckgInfo.name, pckgInfo.versions)

        if (currentVersion != pckgInfo.version) {
          var newerVersions = utilities.getNewerVersions(pckgInfo.versions, currentVersion)
          outdated = utilities.addToArray(outdated, pckgInfo.name, newerVersions)
        }

        callback()
      })
    }
  },
    function (err) {
      if (err) {
        console.log('Error: ' + err)
      } else {
        fs.writeFileSync(path.join(projectRoot, 'cache.json'), JSON.stringify(allDependencies))
        console.log('Outdated dependencies: ' + JSON.stringify(outdated))
      }
      onDone(outdated, allDependencies)
    })
}

function createSandboxAndTestDependency (i, outdated, projectRoot, reportPath, testCmd, config, initialTestsResult, baseVersion, dependencies) {
  if (i == outdated.length) {
    console.log('All done.')
    console.log('Latest passing dependencies: ' + JSON.stringify(passingDepVersions))
  } else {
    var depName = outdated[i].name
    var depVersions = outdated[i].versions
    var latestDepPassing = null
    async.eachSeries(depVersions,
      function (depVersion, callback) {
        var verPath = path.join(projectRoot, 'dependencies', depName, depVersion)
        // var tasks = 'git clone ' + repo + ' ' + verPath + ' && cp -a ' + path.join(baseVersion, 'node_modules') + " " + verPath + '/node_modules/ && cd ' + verPath + ' && npm install ' + depName + '@' + depVersion

        mkdirp.sync(verPath)
        var tasks = 'cp -a ' + baseVersion + '/* ' + verPath + '&& cd ' + verPath + ' && npm install ' + depName + '@' + depVersion
        console.log(tasks)
        childProcess.exec(tasks, function (error, stdout, stderr) {
          childProcess.exec('cd ' + verPath + ' && ' + testCmd, config, function (error, stdout, stderr) {
            fs.writeFileSync(verPath + '/testResults.md', stdout)
            var newTestsResult = utilities.getTestResults(stdout)

            console.log('Test results with ' + depName + '@' + depVersion + ': ' + JSON.stringify(newTestsResult))
            if (newTestsResult.tests != initialTestsResult.tests || newTestsResult.failures != initialTestsResult.failures) {
              fs.appendFileSync(reportPath, depName + '@' + depVersion + ': Failed' + '\n')
            } else {
              fs.appendFileSync(reportPath, depName + '@' + depVersion + ': Passed' + '\n')
              latestDepPassing = depVersion
            }
            console.log(depName + '@' + depVersion + ' done.')
            callback()
          })
        })
      },
      function (err) {
        console.log(depName + ' done.')
        if (latestDepPassing != null) {
          passingDepVersions[depName] = latestDepPassing
        } else {
          passingDepVersions[depName] = dependencies[depName].replace(/[^\d.]/g, '')
        }
        createSandboxAndTestDependency(i + 1, outdated, projectRoot, reportPath, testCmd, config, initialTestsResult, baseVersion, dependencies)
      }
    )
  }
}
