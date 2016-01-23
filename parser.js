"use strict"

var fs = require("fs");
var childProcess = require('child_process');
var async = require("async");
var map = new Object();
var cmpVerModule = require('./compareVersions.js')

var outdated = [];
var allDependencies = [];

if (fs.existsSync('cache.json')) {
    var cacheData = JSON.parse(fs.readFileSync('cache.json', "utf8"));
    for (var i in cacheData) {
        map[cacheData[i].name] = cacheData[i].versions
    }
} else {
    fs.writeFileSync('cache.json', '');
}

function addToArray(array, key, versions) {
    array.push({
        "name": key,
        "versions": versions
    });
}

fs.readFile("package.json", "utf8", function(err, data) {

    var obj = JSON.parse(data);
    var dependencies = obj.dependencies;
    var devDependencies = obj.devDependencies;
    var keys = Object.keys(dependencies);

    async.each(keys, function(key, callback) {

        var currentVersion = dependencies[key].replace(/[^\d.]/g, '');

        if (key in map) {

            var versions = map[key];

            addToArray(allDependencies, key, versions);

            if (currentVersion != versions[versions.length - 1]) {
                var newerVersions = cmpVerModule.getNewerVersions(versions, currentVersion);
                addToArray(outdated, key, newerVersions);
            }

            callback();

        } else {

            childProcess.exec('npm show ' + key + ' --json', function(error, stdout, stderr) {

                var pckgInfo = JSON.parse(stdout);

                addToArray(allDependencies, pckgInfo.name, pckgInfo.versions);

                if (currentVersion != pckgInfo.version) {

                    var newerVersions = cmpVerModule.getNewerVersions(pckgInfo.versions, currentVersion);
                    addToArray(outdated, pckgInfo.name, newerVersions);
                }

                callback();
            })
        }
    }, function(err) {
        if (err) {
            console.log("Error: " + err);
        } else {

            fs.writeFileSync('cache.json', JSON.stringify(allDependencies));

            console.log(JSON.stringify(outdated));



        }
    });

})
