var fs = require('fs');
var childProcess = require('child_process');
var async = require("async");
var utilities = require('./utilities.js')

var repo = process.argv[2];
var projectName = process.argv[3];

utilities.initialSetup(repo, projectName, function () {

    console.log('initialSetup done.');
    utilities.parsePackageJSON(projectName, function (obj) {

        var dependencies = obj.dependencies;
        var devDependencies = obj.devDependencies;
        var keys = Object.keys(dependencies);

        utilities.checkForCache(projectName, function (map) {

            console.log('checkForCache done.');
            var outdated = [];
            var allDependencies = [];

            async.each(keys, function(key, callback) {

                var currentVersion = dependencies[key].replace(/[^\d.]/g, '');

                if (key in map) {
                    console.log('cache exists');
                    var versions = map[key].versions;

                    allDependencies = utilities.addToArray(allDependencies, key, versions);

                    if (currentVersion != versions[versions.length - 1]) {
                        var newerVersions = utilities.getNewerVersions(versions, currentVersion);
                        outdated = utilities.addToArray(outdated, key, newerVersions);
                    }

                    callback();

                } else {
                    console.log("cache doesn't exist.");
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
                    console.log("Outdated: " + JSON.stringify(outdated));

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
                                console.log("Tasks: " + tasks);
                                childProcess.exec(tasks, function(error, stdout, stderr) {
                                    console.log("basic tasks done.");
                                    childProcess.exec('cd ' + verPath + ' && npm test', function(error, stdout, stderr){
                                        console.log(depName + '/' + depVersion + ' done.\n' + stdout + "ERROR: " + stderr);
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
