cd %1

msbuild "%2" /property:Configuration=Debug /property:Platform="Any CPU" /fl1 /fl2 /fl3 /flp2:logfile=BuildErrors.log;errorsonly /flp3:logfile=BuildWarnings.log;warningsonly
pause

mstest /testContainer:"%3" /resultsfile:testResults.trx
pause