FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["SortingApp/SortingApp.csproj", "SortingApp/"]
RUN dotnet restore "SortingApp/SortingApp.csproj"
COPY . .
WORKDIR "/src/SortingApp"
RUN dotnet build "SortingApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SortingApp.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SortingApp.dll"]
