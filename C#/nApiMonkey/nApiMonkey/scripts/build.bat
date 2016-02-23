
set localFolder=%1

cd /d %1

msbuild "%1" /property:Configuration=Debug /property:Platform="AnyCPU"

pause