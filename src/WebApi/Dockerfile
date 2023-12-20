FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Rinha/Rinha.csproj", "Rinha/"]
RUN dotnet restore "Rinha/Rinha.csproj"
COPY . .
WORKDIR "/src/Rinha"
RUN dotnet build "Rinha.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Rinha.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Rinha.dll"]
