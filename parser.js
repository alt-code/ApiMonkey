"use strict"

var fs = require("fs");
var childProcess = require('child_process');
var async = require("async");
var map = new Object();

if (fs.existsSync('cache.json')) {
    var cacheData = JSON.parse(fs.readFileSync('cache.json', "utf8"));
    for (var i in cacheData) {
        map[cacheData[i].name] = cacheData[i].versions
    }
} else {
    fs.writeFileSync('cache.json', '');
}


fs.readFile("package.json", "utf8", function(err, data) {

    var obj = JSON.parse(data);
    var dependencies = obj.dependencies;
    var devDependencies = obj.devDependencies;
    var keys = Object.keys(dependencies);

    var outdated = [];
    var allDependencies = [];

    async.each(keys, function(key, callback) {

        var currentVersion = dependencies[key].replace(/[^\d.]/g, '');

        if(key in map){

            var versions = map[key];

            allDependencies.push({
                "name": key,
                "versions": versions
            });

            if (currentVersion != versions[versions.length - 1]) {
                outdated.push({
                    "name": key,
                    "versions": versions
                });
            }
            callback();

        }else{

            childProcess.exec('npm show ' + key + ' --json', function(error, stdout, stderr) {

                var pckgInfo = JSON.parse(stdout);

                allDependencies.push({
                    "name": pckgInfo.name,
                    "versions": pckgInfo.versions
                });

                if (currentVersion != pckgInfo.version) {
                    outdated.push({
                        "name": pckgInfo.name,
                        "versions": pckgInfo.versions
                    });
                }
                callback();
            })
        }
    }, function(err) {
        if (err) {
            console.log("Error: " + err);
        } else {
            console.log("Ouput: " + JSON.stringify(outdated));
            fs.writeFileSync('cache.json', JSON.stringify(allDependencies));
        }
    });

})
