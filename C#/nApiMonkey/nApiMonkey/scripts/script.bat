echo '$2 = ' %2
echo '$1 = ' %1

cd %1
xcopy /s * %2 /e /q
echo 'copy done'
pause