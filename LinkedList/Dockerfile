﻿FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["LinkedList/LinkedList.csproj", "LinkedList/"]
RUN dotnet restore "LinkedList/LinkedList.csproj"
COPY . .
WORKDIR "/src/LinkedList"
RUN dotnet build "LinkedList.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LinkedList.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LinkedList.dll"]
