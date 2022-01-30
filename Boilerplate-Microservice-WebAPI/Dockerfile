#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Boilerplate-Microservice-WebAPI/Boilerplate-Microservice-WebAPI.csproj", "Boilerplate-Microservice-WebAPI/"]
RUN dotnet restore "Boilerplate-Microservice-WebAPI/Boilerplate-Microservice-WebAPI.csproj"
COPY . .
WORKDIR "/src/Boilerplate-Microservice-WebAPI"
RUN dotnet build "Boilerplate-Microservice-WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Boilerplate-Microservice-WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Boilerplate-Microservice-WebAPI.dll"]