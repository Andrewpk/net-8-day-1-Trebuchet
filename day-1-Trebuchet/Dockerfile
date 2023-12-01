FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["day-1-Trebuchet/day-1-Trebuchet.csproj", "day-1-Trebuchet/"]
RUN dotnet restore "day-1-Trebuchet/day-1-Trebuchet.csproj"
COPY . .
WORKDIR "/src/day-1-Trebuchet"
RUN dotnet build "day-1-Trebuchet.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "day-1-Trebuchet.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "day-1-Trebuchet.dll"]
