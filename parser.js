"use strict"

var fs = require("fs");

fs.readFile("Sample/package.json", "utf8", function(err, data){

  var obj = JSON.parse(data);
  var dependencies = obj.dependencies;
  var devDependencies = obj.devDependencies;
  
})
