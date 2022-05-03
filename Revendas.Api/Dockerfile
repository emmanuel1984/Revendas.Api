#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app
EXPOSE 80
EXPOSE 443

ENV ASPNETCORE_URLS=http://+:8000;http://+:80;
ENV ASPNETCORE_ENVIRONMENT=Development

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Revendas.Api.csproj", "."]
RUN dotnet restore "./Revendas.Api.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Revendas.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Revendas.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Revendas.Api.dll"]