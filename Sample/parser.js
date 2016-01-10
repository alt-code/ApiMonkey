"use strict"

var fs = require("fs");
var childProcess = require('child_process');

fs.readFile("package.json", "utf8", function(err, data){

  var obj = JSON.parse(data);
  var dependencies = obj.dependencies;
  var devDependencies = obj.devDependencies;

  for(var key in dependencies){
    var installedVersion = dependencies[key];
    childProcess.exec('npm show ' + key + ' --json', function(error, stdout, stderr){
      var pckgInfo = JSON.parse(stdout)
      // console.log(pckgInfo)
      console.log(pckgInfo.name + " : " + pckgInfo.versions)
    });
  }

})
