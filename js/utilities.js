var fs = require('fs')
var path = require('path')
var mkdirp = require('mkdirp')
var childProcess = require('child_process')
var parser = require('xml2json')
var Promise = require("bluebird")

// https://maymay.net/blog/2008/06/15/ridiculously-simple-javascript-version-string-to-object-parser/
function parseVersionString (str) {
  if (typeof (str) != 'string') {
    return false
  }
  var x = str.split('.')
  // parse from string or default to 0 if can't parse
  var maj = parseInt(x[0]) || 0
  var min = parseInt(x[1]) || 0
  var pat = parseInt(x[2]) || 0
  return {
    major: maj,
    minor: min,
    patch: pat
  }
}

var cmdMap = {}

// base install 
var PROJECTS_ROOT = "projects";

// multiple test suites can be added here

cmdMap['mocha'] = function (cmd) {
  var modifyCmd = ''
  if (cmd.indexOf('--reporter') == -1 && cmd.indexOf('-R') == -1) {
    modifyCmd = cmd.replace(/mocha/g, 'mocha -R xunit')
  } else if (cmd.indexOf('--reporter') != -1) {
    var words = cmd.split(' ')
    var toReplace = words[words.indexOf('--reporter') + 1]
    modifyCmd = cmd.replace(toReplace, 'xunit')
  } else if (cmd.indexOf('-R') != -1) {
    var words = cmd.split(' ')
    var toReplace = words[words.indexOf('-R') + 1]
    modifyCmd = cmd.replace(toReplace, 'xunit')
  }
  return modifyCmd
}

module.exports = {
  getNewerVersions: function (versionArray, installedVersion) {
    var newerVersions = []
    for (var i = 0; i < versionArray.length; i++) {
      var ver = parseVersionString(versionArray[i])
      var curVer = parseVersionString(installedVersion)
      if (curVer.major < ver.major) {
        newerVersions.push(versionArray[i])
      } else if (curVer.major == ver.major) {
        if (parseFloat(curVer.minor) < parseFloat(ver.minor)) {
          newerVersions.push(versionArray[i])
        } else if (curVer.minor == ver.minor) {
          if (parseFloat(curVer.patch) < parseFloat(ver.patch)) {
            newerVersions.push(versionArray[i])
          }
        }
      }
    }
    return newerVersions
  },

  modifyTestCmd: function (obj) {
    var testCmd = obj.scripts['test']
    if (testCmd.indexOf('mocha') != -1) {
      return cmdMap['mocha'](testCmd)
    }
  },

  initialSetup: function (url, projectName) {
    var env = process.env
    env.PATH = env.PATH + ':node_modules/.bin'
    var config = {
        env: env,
        stdio: ['pipe', 'pipe', 'pipe']
    }
    // Create projects directory
    var baseVersion = path.join(PROJECTS_ROOT, projectName, "baseVersion");
    mkdirp.sync(baseVersion);

    // Reset report
    var reportPath = path.join(PROJECTS_ROOT, projectName, "report.md");
    fs.closeSync(fs.openSync(reportPath, 'w'));

    return new Promise(function (resolve, reject) 
    {
        // git clone into baseVersion (if doesn't already exists)
        if( !fs.existsSync( path.join(baseVersion,'.git') ))
        {
            childProcess.execSync('git clone ' + url + ' ' + ' ' + baseVersion);
            // Install 
            childProcess.exec('cd ' + baseVersion + '&& npm install', function(err, stdout, stderr) {
                // 
                resolve([config, PROJECTS_ROOT, reportPath, baseVersion, err]);
            });
        }
        else
        {
            resolve([config, PROJECTS_ROOT, reportPath, baseVersion, null]);
        }
    });
  },


  addToArray: function (array, key, versions, url) {
    array.push({
      'name': key,
      'versions': versions
    })
    return array
  },

  checkForCache: function (cachePath) 
  {
    var map = {};
    var cache = path.join(cachePath, "cache.json");
    if (fs.existsSync(cache))
    {
        var cacheData = JSON.parse(fs.readFileSync(cache, 'utf8'));
        for (var i in cacheData) {
            var obj = {};
            obj.versions = cacheData[i].versions;
            obj.url = cacheData[i].url;
            map[cacheData[i].name] = obj;
        }
    } else {
      fs.writeFileSync(cache, '')
    }
    return map;
  },

  parsePackageJSON: function (path, callback) {
    try {
        var data = fs.readFileSync(path + '/package.json', 'utf8');
        return JSON.parse(data);
    } 
    catch (e) {
        return null;
    }
  },

  runInitialTests: function (projectName, testCmd, callback) {
    childProcess.exec('cd ' + projectName + ' && ' + testCmd, function (err, stdout, stderr) {
      callback(stdout)
    })
  },

  getTestResults: function (testXML) {
    var result = {
      tests: 0,
      failures: 0
    }
    var lines = testXML.split('\n')

    for (var i = 0; i < lines.length; i++) {
      var line = lines[i]
      if (line.indexOf('<testsuite') != -1) {
        var json = JSON.parse(parser.toJson(line))
        result.tests += parseInt(json.testsuite.tests)
        result.failures += parseInt(json.testsuite.failures)
      }
    }
    return result;
  },

  removeSandbox: function (projectName, callback) {
    //fs.exec('rm report.md && rm -rf ' + projectName, function (err, stdout, stderr) {
      callback()
    //})
  }
}
