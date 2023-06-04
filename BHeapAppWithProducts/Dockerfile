FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["BHeapAppWithProducts/BHeapAppWithProducts.csproj", "BHeapAppWithProducts/"]
RUN dotnet restore "BHeapAppWithProducts/BHeapAppWithProducts.csproj"
COPY . .
WORKDIR "/src/BHeapAppWithProducts"
RUN dotnet build "BHeapAppWithProducts.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BHeapAppWithProducts.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BHeapAppWithProducts.dll"]
