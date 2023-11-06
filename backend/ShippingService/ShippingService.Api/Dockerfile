#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["ShippingService.Api/ShippingService.Api.csproj", "ShippingService.Api/"]
COPY ["ShippingService.Application/ShippingService.Application.csproj", "ShippingService.Application/"]
COPY ["ShippingService.Domain/ShippingService.Domain.csproj", "ShippingService.Domain/"]
COPY ["ShippingService.Infrastructure/ShippingService.Infrastructure.csproj", "ShippingService.Infrastructure/"]
RUN dotnet restore "ShippingService.Api/ShippingService.Api.csproj"
COPY . .
WORKDIR "/src/ShippingService.Api"
RUN dotnet build "ShippingService.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ShippingService.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ShippingService.Api.dll"]