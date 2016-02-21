var fs = require('fs')
var childProcess = require('child_process')

// https://maymay.net/blog/2008/06/15/ridiculously-simple-javascript-version-string-to-object-parser/
function parseVersionString(str) {
    if (typeof(str) != 'string') {
        return false;
    }
    var x = str.split('.');
    // parse from string or default to 0 if can't parse
    var maj = parseInt(x[0]) || 0;
    var min = parseInt(x[1]) || 0;
    var pat = parseInt(x[2]) || 0;
    return {
        major: maj,
        minor: min,
        patch: pat
    }
}

var cmdMap = {};

// multiple test suites can be added here

cmdMap['mocha'] = function (cmd) {
    return cmd.replace(/mocha/g, 'mocha -R xunit')
}

module.exports = {

    getNewerVersions: function (versionArray, installedVersion) {
        var newerVersions = [];
        for (var i = 0; i < versionArray.length; i++) {
            var ver = parseVersionString(versionArray[i]);
            var curVer = parseVersionString(installedVersion);
            if (curVer.major < ver.major) {
                newerVersions.push(versionArray[i]);
            } else if (curVer.major == ver.major) {
                if (parseFloat(curVer.minor) < parseFloat(ver.minor)) {
                    newerVersions.push(versionArray[i]);
                }else if(curVer.minor == ver.minor){
                    if (parseFloat(curVer.patch) < parseFloat(ver.patch)) {
                        newerVersions.push(versionArray[i]);
                    }
                }
            }
        }
        return newerVersions;
    },

    modifyTestCmd: function (obj) {
        var testCmd = obj.scripts['test']
        if(testCmd.indexOf('mocha') != 0){
            return cmdMap['mocha'](testCmd)
        }
    },

    initialSetup: function (url, projectName, callback) {
        var env = process.env
        env.PATH = env.PATH + ':node_modules/.bin'
        var config = {
            env: env
        }
        childProcess.exec('git clone ' + url + ' ' + projectName + ' && cd ' + projectName + ' && npm install', function(){
            callback(config)
        })
    },

    addToArray: function (array, key, versions, url) {
        array.push({
            "name": key,
            "versions": versions
        });
        return array
    },

    checkForCache: function (path, callback) {
        var map = new Object();
        if (fs.existsSync(path + '/cache.json')) {
            var cacheData = JSON.parse(fs.readFileSync(path + '/cache.json', "utf8"));
            for (var i in cacheData) {
                var obj = {};
                obj.versions = cacheData[i].versions;
                obj.url = cacheData[i].url
                map[cacheData[i].name] = obj
            }
        } else {
            fs.writeFileSync(path + '/cache.json', '');
        }
        callback(map)
    },

    parsePackageJSON: function (path, callback) {
        fs.readFile(path + '/package.json', "utf8", function(err, data) {
            var obj = JSON.parse(data);
            callback(obj)
        })
    }
}
