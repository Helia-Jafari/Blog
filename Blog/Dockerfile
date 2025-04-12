# Stage 1: Base Image
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# Stage 2: Build Image
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copy csproj files separately and restore as distinct layers
COPY Blog/Blog.csproj Blog/
COPY Blog.CoreLayer/Blog.CoreLayer.csproj Blog.CoreLayer/

RUN dotnet restore Blog/Blog.csproj

# Copy everything else
COPY Blog/ Blog/
COPY Blog.CoreLayer/ Blog.CoreLayer/

WORKDIR /src/Blog

# Build the project
RUN dotnet build Blog.csproj -c $BUILD_CONFIGURATION -o /app/build

# Stage 3: Publish
FROM build AS publish
RUN dotnet publish Blog.csproj -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Stage 4: Final Image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Blog.dll"]
