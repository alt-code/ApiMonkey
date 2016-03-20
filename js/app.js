var fs = require('fs')
var childProcess = require('child_process')
var async = require('async')
var utilities = require('./utilities.js')

var repo = process.argv[2]
var projectName = process.argv[3]

utilities.initialSetup(repo, projectName, function (config, err) {
  if (err != null) {
    utilities.removeSandbox(projectName, function () {
      console.log('Error installing node dependencies.')
    })
  } else {
    console.log('Initial setup done.')

    utilities.parsePackageJSON(projectName, function (obj) {
      console.log('Parse package done.')

      var dependencies = obj.dependencies
      var devDependencies = obj.devDependencies
      var keys = Object.keys(dependencies)
      var testCmd = utilities.modifyTestCmd(obj)

      utilities.runInitialTests(projectName, testCmd, function (output) {
        console.log('Initial tests done.')

        utilities.getNumbers(output, function (initialTestsResult) {
          console.log('Initial tests results: ' + JSON.stringify(initialTestsResult))

          utilities.checkForCache(projectName, function (map) {
            console.log('Check for cache done.')

            var outdated = []
            var allDependencies = []

            async.each(keys, function (key, callback) {
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
            }, function (err) {
              if (err) {
                console.log('Error: ' + err)
              } else {
                fs.writeFileSync(projectName + '/cache.json', JSON.stringify(allDependencies))
                console.log('Outdated dependencies: ' + JSON.stringify(outdated))

                loop(0)

                function loop (i) {
                  if (i == outdated.length) {
                    console.log('All done.')
                  } else {
                    var depName = outdated[i].name
                    var depVersions = outdated[i].versions
                    async.eachSeries(depVersions, function (depVersion, callback) {
                      var verPath = projectName + '/dependencies/' + depName + '/' + depVersion
                      var tasks = 'git clone ' + repo + ' ' + verPath + ' && cp -a ' + projectName + '/node_modules/ ' + verPath + '/node_modules/ && cd ' + verPath + ' && npm install ' + depName + '@' + depVersion
                      childProcess.exec(tasks, function (error, stdout, stderr) {
                        childProcess.exec('cd ' + verPath + ' && ' + testCmd, config, function (error, stdout, stderr) {
                          fs.writeFileSync(verPath + '/testResults.md', stdout)
                          utilities.getNumbers(stdout, function (newTestsResult) {
                            console.log('Test results with ' + depName + '@' + depVersion + ': ' + JSON.stringify(newTestsResult))
                            if (newTestsResult.tests != initialTestsResult.tests || newTestsResult.failures != initialTestsResult.failures) {
                              fs.appendFileSync('report.md', depName + '@' + depVersion + ': Failed' + '\n')
                            } else {
                              fs.appendFileSync('report.md', depName + '@' + depVersion + ': Passed' + '\n')
                            }
                            console.log(depName + '@' + depVersion + ' done.')
                            callback()
                          })
                        })
                      })
                    }, function (err) {
                      console.log(depName + ' done.')
                      loop(i + 1)
                    })
                  }
                }
              }
            })
          })
        })
      })
    })
  }
})
