# Stage 1
FROM microsoft/aspnetcore-build AS builder
WORKDIR /source

# Copy application code
COPY . .
RUN dotnet restore 
RUN dotnet publish --output /app/ --configuration Release

# Stage 2
FROM microsoft/aspnetcore
WORKDIR /app
COPY --from=builder /app .
ENTRYPOINT ["dotnet", "CryptoNetWorth.Api.dll"]