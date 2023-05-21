FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["StackApp/StackApp.csproj", "StackApp/"]
RUN dotnet restore "StackApp/StackApp.csproj"
COPY . .
WORKDIR "/src/StackApp"
RUN dotnet build "StackApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "StackApp.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StackApp.dll"]
