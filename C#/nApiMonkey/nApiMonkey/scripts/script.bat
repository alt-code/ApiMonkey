cd %1
xcopy /s * %2 /e /q
echo 'copy done'
del TestResults.trx
del BuildErrors.log
del BuildWarnings.log
