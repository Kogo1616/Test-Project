FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["Test-Project/Test-Project.csproj", "Test-Project/"]
RUN dotnet restore "Test-Project/Test-Project.csproj"
COPY . .
WORKDIR "/src/Test-Project"
RUN dotnet build "Test-Project.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Test-Project.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Test-Project.dll"]
