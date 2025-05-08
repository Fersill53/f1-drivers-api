# Use .NET 8 SDK image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy everything
COPY . ./

# Restore dependencies
RUN dotnet restore

# Build and publish
RUN dotnet publish -c Release -o out

# Run stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

# Expose port from Railway
ENV ASPNETCORE_URLS=http://+:${PORT}
ENTRYPOINT ["dotnet", "F1DriversApi.dll"]
