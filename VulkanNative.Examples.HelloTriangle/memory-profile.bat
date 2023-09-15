@echo off

SETLOCAL

start /b ./bin/Debug/net7.0/VulkanNative.Examples.HelloTriangle.exe

FOR /F %%T IN ('Wmic process where^(Name^="VulkanNative.Examples.HelloTriangle.exe"^)get ProcessId^|more +1') DO (SET /A PID=%%T) &GOTO SkipLine  
:SkipLine

start /b dotnet-trace collect --profile gc-verbose --process-id %PID%