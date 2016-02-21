var fs = require('fs');
var childProcess = require('child_process');
var async = require("async");
var utilities = require('./utilities.js')

var repo = process.argv[2];
var projectName = process.argv[3];

utilities.initialSetup(repo, projectName, function (config) {

    utilities.parsePackageJSON(projectName, function (obj) {

        var dependencies = obj.dependencies;
        var devDependencies = obj.devDependencies;
        var keys = Object.keys(dependencies);
        var testCmd = utilities.modifyTestCmd(obj)

        utilities.checkForCache(projectName, function (map) {

            var outdated = [];
            var allDependencies = [];

            async.each(keys, function(key, callback) {

                var currentVersion = dependencies[key].replace(/[^\d.]/g, '');

                if (key in map) {
                    var versions = map[key].versions;

                    allDependencies = utilities.addToArray(allDependencies, key, versions);

                    if (currentVersion != versions[versions.length - 1]) {
                        var newerVersions = utilities.getNewerVersions(versions, currentVersion);
                        outdated = utilities.addToArray(outdated, key, newerVersions);
                    }

                    callback();

                } else {

                    childProcess.exec('npm show ' + key + ' --json', function(error, stdout, stderr) {

                        var pckgInfo = JSON.parse(stdout);

                        allDependencies = utilities.addToArray(allDependencies, pckgInfo.name, pckgInfo.versions);

                        if (currentVersion != pckgInfo.version) {
                            var newerVersions = utilities.getNewerVersions(pckgInfo.versions, currentVersion);
                            outdated = utilities.addToArray(outdated, pckgInfo.name, newerVersions);
                        }

                        callback();
                    })
                }
            }, function(err) {
                if (err) {
                    console.log("Error: " + err);
                } else {

                    fs.writeFileSync(projectName + '/cache.json', JSON.stringify(allDependencies));

                    loop(0);

                    function loop(i) {
                        if (i == outdated.length) {
                            console.log("All done.");
                        } else {
                            var depName = outdated[i].name;
                            var depVersions = outdated[i].versions;
                            async.each(depVersions, function(depVersion, callback) {

                                var verPath =  projectName + '/dependencies/' + depName + '/' + depVersion
                                var tasks = 'git clone ' + repo + ' ' + verPath + ' && cd ' + verPath + ' && npm install && npm install ' +  depName + '@' + depVersion;
                                childProcess.exec(tasks, function(error, stdout, stderr) {
                                    childProcess.exec('cd ' + verPath + ' && ' + testCmd, config, function(error, stdout, stderr){
                                        console.log(stdout + "\n" + depName + '/' + depVersion + ' done.\n');
                                        callback();
                                    })
                                })

                            }, function(err) {
                                console.log(depName + ' done.');
                                loop(i + 1);
                            })
                        }
                    }
                }
            });
        })
    })
})
