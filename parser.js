"use strict"

var fs = require("fs");
var childProcess = require('child_process');
var async = require("async");

fs.readFile("package.json", "utf8", function(err, data) {

    var obj = JSON.parse(data);
    var dependencies = obj.dependencies;
    var devDependencies = obj.devDependencies;
    var keys = Object.keys(dependencies);

    var outdated = [];

    // console.log(dependencies);

    // for (var key in dependencies) {
    //   var installedVersion = dependencies[key];
    //   childProcess.exec('npm show ' + key + ' --json', function(error, stdout, stderr) {
    //     var pckgInfo = JSON.parse(stdout)
    //       // console.log(pckgInfo)
    //     console.log(pckgInfo.name + " : " + pckgInfo.versions)
    //   });
    // }

    // function loop(i) {
    //     if (i == keys.length) {
    //         console.log(out);
    //     } else {
    //
    //         var installedVersion = dependencies[keys[i]];
    //
    //         childProcess.exec('npm show ' + keys[i] + ' --json', function(error, stdout, stderr) {
    //             var pckgInfo = JSON.parse(stdout);
    //             // console.log(pckgInfo)
    //             out.push({
    //                 "name": pckgInfo.name,
    //                 "versions": pckgInfo.versions
    //             });
    //             loop(i + 1)
    //         });
    //     }
    // }
    // loop(0);

    async.each(keys, function(key, callback) {

        childProcess.exec('npm show ' + key + ' --json', function(error, stdout, stderr) {

            var pckgInfo = JSON.parse(stdout);
            var currentVersion = dependencies[key].replace(/[^\d.]/g, '');

            if(currentVersion !== pckgInfo.version){
                outdated.push({
                    "name": pckgInfo.name,
                    "versions": pckgInfo.versions,
                    "installedVersion": currentVersion
                });
            }
            callback();
        })
    }, function(err) {
        if (err) {
            console.log("Error:" + err);
        } else {
            console.log("Output: " + JSON.stringify(outdated));
        }
    });

})
