var fs = require('fs');
var childProcess = require('child_process');
var async = require("async");
var utilities = require('./utilities.js')

var repo = process.argv[2];
var projectName = process.argv[3];

utilities.initialSetup(repo, projectName, function(config, reportPath, baseVersion) {
    console.log('Initial setup done.');

    utilities.parsePackageJSON(baseVersion, function(obj) {
        console.log('Parse package done.');

        var dependencies = obj.dependencies;
        var devDependencies = obj.devDependencies;
        var keys = Object.keys(dependencies);
        var testCmd = utilities.modifyTestCmd(obj)
        console.log("Modify test command: ", testCmd);

        return;
        utilities.runInitialTests(projectName, testCmd, function(output) {
            console.log('Initial tests done.');

            utilities.getNumbers(output, function(initialTestsResult) {
                console.log('Initial tests results: ' + JSON.stringify(initialTestsResult));

                utilities.checkForCache(projectName, function(map) {
                    console.log('Check for cache done.');

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
                            console.log('Outdated dependencies: ' + JSON.stringify(outdated));

                            loop(0);

                            function loop(i) {
                                if (i == outdated.length) {
                                    console.log("All done.");
                                } else {
                                    var depName = outdated[i].name;
                                    var depVersions = outdated[i].versions;
                                    async.each(depVersions, function(depVersion, callback) {

                                        var verPath = projectName + '/dependencies/' + depName + '/' + depVersion
                                        //var tasks = 'git clone ' + repo + ' ' + verPath + ' && cd ' + verPath + ' && npm install && npm install ' + depName + '@' + depVersion;

                                        var stdout = childProcess.execSync(tasks);
                                            //function(error, stdout, stderr) {
                                        stdout = stdout.toString();
                                        {
                                             stdout = childProcess.execSync('cd ' + verPath + ' && ' + testCmd, config);
                                             stdout = stdout.toString();
                                             //function(error, stdout, stderr) 
                                             {
                                                utilities.getNumbers(stdout, function(newTestsResult) {
                                                    console.log("Test results with " + depName + '@' + depVersion + ': ' + JSON.stringify(newTestsResult));
                                                    if (newTestsResult.tests != initialTestsResult.tests || newTestsResult.failures != initialTestsResult.failures) {
                                                        fs.appendFileSync('report.md', depName + '@' + depVersion + ': Failed' + '\n')
                                                    } else {
                                                        fs.appendFileSync('report.md', depName + '@' + depVersion + ': Passed' + '\n')
                                                    }
                                                    console.log(depName + '@' + depVersion + ' done.');
                                                    callback();
                                                })
                                            }
                                        }

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
    })
})
