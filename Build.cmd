@echo off
set msbuildpath="C:\Program Files\Microsoft Visual Studio\2022\Enterprise\MSBuild\Current\Bin"
set svnpath="C:\Program Files\TortoiseSVN\bin"

set path=%svnpath%;%msbuildpath%;%path%

rem svn up

msbuild /t:restore /t:rebuild /p:configuration="release" /p:Platform="x64"  ModelCreater.sln

pause