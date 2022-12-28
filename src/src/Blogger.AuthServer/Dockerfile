#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["NuGet.Config", "."]
COPY ["src/Blogger.AuthServer/Blogger.AuthServer.csproj", "src/Blogger.AuthServer/"]
COPY ["src/Blogger.EntityFrameworkCore/Blogger.EntityFrameworkCore.csproj", "src/Blogger.EntityFrameworkCore/"]
COPY ["src/Blogger.Domain/Blogger.Domain.csproj", "src/Blogger.Domain/"]
COPY ["src/Blogger.Domain.Shared/Blogger.Domain.Shared.csproj", "src/Blogger.Domain.Shared/"]
RUN dotnet restore "src/Blogger.AuthServer/Blogger.AuthServer.csproj"
COPY . .
WORKDIR "/src/src/Blogger.AuthServer"
RUN dotnet build "Blogger.AuthServer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Blogger.AuthServer.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Blogger.AuthServer.dll"]