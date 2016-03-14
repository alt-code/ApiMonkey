cd %1
msbuild "%2" /property:Configuration=Debug /property:Platform="AnyCPU" /fl1 /fl2 /fl3 /flp2:logfile=BuildErrors.log;errorsonly /flp3:logfile=BuildWarnings.log;warningsonly
