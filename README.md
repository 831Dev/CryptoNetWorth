# CryptoNetWorth
A simple .NET Core Api using EF Core, MySQL, and Docker.

### REQUIREMENTS
1. .NET Core: https://www.microsoft.com/net/core#macos
2. MySQL: https://www.mysql.com/

### RUNING FROM LOCALHOST
1. Clone repo
2. Add your MySQL server credentials to CryptoNetWorth.Api > appsettings.json
3. dotnet restore
4. CD CryptoNetWorth.Api
5. dotnet run
6. open http://localhost:5000/api/digitalassets

### RUNNING FROM DOCKER
1. Clone repo
2. Add your MySQL server credentials to CryptoNetWorth.Api > appsettings.json