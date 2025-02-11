FROM mcr.microsoft.com/dotnet/runtime:9.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["ReportingJob/ReportingJob.csproj", "ReportingJob/"]
RUN dotnet restore "ReportingJob/ReportingJob.csproj"
COPY . .
WORKDIR "/src/ReportingJob"
RUN dotnet build "ReportingJob.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ReportingJob.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ReportingJob.dll"]
