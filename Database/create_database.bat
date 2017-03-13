@echo off
set /p password="Enter password for sa account: "
echo Starting create database script
sqlcmd -S localhost\masterdb -U sa -P %password% -i Create\create_script.sql
echo Creation of database completed
pause