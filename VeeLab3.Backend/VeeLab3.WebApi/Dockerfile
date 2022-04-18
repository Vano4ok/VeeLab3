FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["VeeLab3.WebApi/VeeLab3.WebApi.csproj", "VeeLab3.WebApi/"]
COPY ["VeeLab3.Domain/VeeLab3.Domain.csproj", "VeeLab3.Domain/"]
RUN dotnet restore "VeeLab3.WebApi/VeeLab3.WebApi.csproj"
COPY . .
WORKDIR "/src/VeeLab3.WebApi"
RUN dotnet build "VeeLab3.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "VeeLab3.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "VeeLab3.WebApi.dll"]