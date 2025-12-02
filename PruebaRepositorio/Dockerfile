FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 10000
ENV ASPNETCORE_URLS=http://+:10000

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
# Copia el .csproj desde la carpeta PruebaRepositorio
COPY ["PruebaRepositorio/PruebaRepositorio.csproj", "./"]
RUN dotnet restore "PruebaRepositorio.csproj"

# Copia todo el proyecto
COPY . .
# Mueve el WORKDIR a la carpeta del proyecto
WORKDIR "/src/PruebaRepositorio"
RUN dotnet build "PruebaRepositorio.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PruebaRepositorio.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PruebaRepositorio.dll"]
