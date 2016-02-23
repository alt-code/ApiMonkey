echo '$2 = ' %2
echo '$1 = ' %1

cd %1
xcopy /s * %2
echo 'copy done'
pause
