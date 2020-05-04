#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Presentation/Smi.Web/Smi.Web.csproj", "Presentation/Smi.Web/"]
COPY ["Libraries/Smi.Data/Smi.Data.csproj", "Libraries/Smi.Data/"]
COPY ["Libraries/Smi.Core/Smi.Core.csproj", "Libraries/Smi.Core/"]
COPY ["Libraries/Smi.Services/Smi.Services.csproj", "Libraries/Smi.Services/"]
COPY ["Presentation/Smi.Web.Framework/Smi.Web.Framework.csproj", "Presentation/Smi.Web.Framework/"]
RUN dotnet restore "Presentation/Smi.Web/Smi.Web.csproj"
COPY . .
WORKDIR "/src/Presentation/Smi.Web"
RUN dotnet build "Smi.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Smi.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Smi.Web.dll"]