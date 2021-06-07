#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["TiEventsy.Gateway.DesktopGrpcService/TiEventsy.Gateway.DesktopGrpcService.csproj", "TiEventsy.Gateway.DesktopGrpcService/"]
RUN dotnet restore "TiEventsy.Gateway.DesktopGrpcService/TiEventsy.Gateway.DesktopGrpcService.csproj"
COPY . .
WORKDIR "/src/TiEventsy.Gateway.DesktopGrpcService"
RUN dotnet build "TiEventsy.Gateway.DesktopGrpcService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TiEventsy.Gateway.DesktopGrpcService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TiEventsy.Gateway.DesktopGrpcService.dll"]