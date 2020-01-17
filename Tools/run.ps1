invoke-command dotnet publish -c Release -r win10-x64
invoke-command "./bin/Debug/netcoreapp2.1/win10-x64/003-addBorder.exe"
REM - or use "dotnet run" to run a dll