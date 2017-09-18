# CryptoNetWorth
A simple .NET Core Api using EF Core, MySQL, and Docker.

### REQUIRED SOFTWARE
1. .NET Core: https://www.microsoft.com/net/core#macos
2. MySQL: https://www.mysql.com/

### SET UP THE PROJECT
1. Clone repo
2. Add your MySQL server credentials to CryptoNetWorth.Api > appsettings.json

## RUNNING LOCALLY WITH KESTREL
1. dotnet restore
2. cd CryptoNetWorth.Api
3. dotnet run

### RUNNING FROM DOCKER
1. docker build -t cryptonetworth .
2. docker run -d -p 8080:80 --name cryptonetworthapp cryptonetworth