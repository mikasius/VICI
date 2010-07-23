@echo off
set SCRIPT=%0
set SCRIPT=%SCRIPT: =%

set GIT_EXEC_PATH=%~dp0tools\Git

C:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.EXE src\Vici.msbuild %*

:: Pauses the script if it was executed from Explorer rather than the command line.  See the comment for http://stackoverflow.com/questions/377407/detecting-how-a-batch-file-was-executed/377933#377933
if not "%SCRIPT:"=%"=="%SCRIPT%" pause