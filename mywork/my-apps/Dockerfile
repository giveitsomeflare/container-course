FROM mcr.microsoft.com/dotnet/core/runtime:3.1-buster-slim AS base
        WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["strings-app/strings-app.csproj", "strings-app/"]
RUN dotnet restore "strings-app/strings-app.csproj"
COPY . .
WORKDIR "/src/strings-app"
RUN dotnet build "strings-app.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "strings-app.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "strings-app.dll"]