FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["KillerApp/KillerApp.csproj", "KillerApp/"]
RUN dotnet restore "KillerApp/KillerApp.csproj"
COPY . .
WORKDIR "/src/KillerApp"
RUN dotnet build "KillerApp.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "KillerApp.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "KillerApp.dll"]