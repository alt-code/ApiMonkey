"use strict"

var fs = require("fs");
var childProcess = require('child_process');

fs.readFile("package.json", "utf8", function(err, data) {

    var obj = JSON.parse(data);
    var dependencies = obj.dependencies;
    var devDependencies = obj.devDependencies;
    var keys = Object.keys(dependencies);

    console.log(dependencies)

    // for (var key in dependencies) {
    //   var installedVersion = dependencies[key];
    //   childProcess.exec('npm show ' + key + ' --json', function(error, stdout, stderr) {
    //     var pckgInfo = JSON.parse(stdout)
    //       // console.log(pckgInfo)
    //     console.log(pckgInfo.name + " : " + pckgInfo.versions)
    //   });
    // }

    var out = [];

    function loop(i) {
        if (i == keys.length) {
            console.log(out);
        } else {

            var installedVersion = dependencies[keys[i]];

            childProcess.exec('npm show ' + keys[i] + ' --json', function(error, stdout, stderr) {
                var pckgInfo = JSON.parse(stdout);
                // console.log(pckgInfo)
                out.push({
                    "name": pckgInfo.name,
                    "versions": pckgInfo.versions
                });
                loop(i + 1)
            });
        }
    }

    // loop(0);

})
