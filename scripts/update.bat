@echo off
echo Updating virus database...
dotnet run --project Updater.csproj
echo Update complete.
pause
