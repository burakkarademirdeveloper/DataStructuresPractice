FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Nodecs/Nodecs.csproj", "Nodecs/"]
RUN dotnet restore "Nodecs/Nodecs.csproj"
COPY . .
WORKDIR "/src/Nodecs"
RUN dotnet build "Nodecs.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Nodecs.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Nodecs.dll"]
