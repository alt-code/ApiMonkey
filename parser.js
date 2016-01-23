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
        var obj = {};
        obj.versions = cacheData[i].versions;
        obj.url = cacheData[i].url
        map[cacheData[i].name] = obj
    }
} else {
    fs.writeFileSync('cache.json', '');
}

function addToArray(array, key, versions, url) {
    array.push({
        "name": key,
        "versions": versions,
        "url": url
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

            var versions = map[key].versions;

            addToArray(allDependencies, key, versions, map[key].url);

            if (currentVersion != versions[versions.length - 1]) {
                var newerVersions = cmpVerModule.getNewerVersions(versions, currentVersion);
                addToArray(outdated, key, newerVersions, map[key].url);
            }

            callback();

        } else {

            childProcess.exec('npm show ' + key + ' --json', function(error, stdout, stderr) {

                var pckgInfo = JSON.parse(stdout);

                addToArray(allDependencies, pckgInfo.name, pckgInfo.versions, pckgInfo.repository.url);

                if (currentVersion != pckgInfo.version) {

                    var newerVersions = cmpVerModule.getNewerVersions(pckgInfo.versions, currentVersion);
                    addToArray(outdated, pckgInfo.name, newerVersions, pckgInfo.repository.url);
                }

                callback();
            })
        }
    }, function(err) {
        if (err) {
            console.log("Error: " + err);
        } else {

            fs.writeFileSync('cache.json', JSON.stringify(allDependencies));

            



        }
    });

})
