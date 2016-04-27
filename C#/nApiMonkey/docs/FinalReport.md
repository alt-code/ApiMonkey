# API Monkey (for C# Projects) #
This research project was done by Tanvi Mainkar under the guidance of *Prof. Dr. Christopher Parnin*.

## Introduction ##
One of the major concepts of an evolving  software system is the idea of "design for failure".  This project implements an "API Monkey", which systematically identifies and updates versions of all the dependencies in a software project. This way, one can verify in advance whether updating the dependencies  to their higher versions will result in a success or a failure. Many a times software projects have to go through trouble of identifying which upgrade resulted in build failure and what actions need to be taken to fix them. With the implementation of an API monkey, it will be easier to identify such potential issues in advance so that developer would know what additional effort/integration changes are required to perform these updates. As part of independent study under Dr. Parnin, I have tried to experiment with the same. 

## Purpose ##
The purpose of this project is to find potential failures in a software project that can be caused by a version upgrade before they occur and notify the developers to take required action. We are using [Nuget](https://www.nuget.org/ "Nuget") package manager and it's apis to implement this tool.

## Process ##
The tools starts with cloning a project from git repository (This step can also be done manually.)
We started working on .net projects to identify their structure and how they are built using visual studio. We identified that the *packages.config* file is a good place to identify the dependencies that a project has. So the tool scans the project folder to identify all the *packages.config* files and reads them one by one. Based on the values read from this file, the tool talks to the NuGet gallery and gathers list of versions higher than currently referenced version in *packages.config* files. Also a map is maintained to keep a track of a package and all the projects referring to that particular dependency. The tool then creates a sandbox folder for each of these versions and performs the update. After updating the project to a new version, it runs *msbuild* and stores the result of the build in log files. Also the error and warnings are stored in separate files. It also runs the unit tests located in the test folder and stores the result in a .trx file. Combined result of the build and test output is written to a final report file. This process is repeated for every newer version of every package referenced by the project. A sample report file can be found [here](https://github.com/alt-code/ApiMonkey/blob/master/C%23/README.md).

## How to run API monkey ##
The running instructions for the project can be found [here](https://github.com/alt-code/ApiMonkey/blob/master/C%23/README.md). 

## Future Work ##
- Implement a notification mechanism.
- Modify the final report format to provide a better diff of the original build/test results and upgraded versions' results.
- Integrate the stack trace of any failures in the final report. Right now, it is present in individual report files in the sandbox folders.
- Enhance the behavior of the monkey to support other test frameworks such as xunit, nunit. 

## References ##
- [https://docs.nuget.org](https://docs.nuget.org)
- [http://blog.nuget.org/20130520/Play-with-packages.html](http://blog.nuget.org/20130520/Play-with-packages.html)
- [http://ivonna.biz/blog/2014/9/21/installing-a-nuget-package-programmatically.aspx](http://ivonna.biz/blog/2014/9/21/installing-a-nuget-package-programmatically.aspx)
- [https://github.com/NuGet/Home](https://github.com/NuGet/Home)