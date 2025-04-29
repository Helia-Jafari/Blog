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
COPY Blog.DataLayer/Blog.DataLayer.csproj Blog.DataLayer/

RUN dotnet restore Blog/Blog.csproj

# Copy everything else
COPY Blog/ Blog/
COPY Blog.CoreLayer/ Blog.CoreLayer/
COPY Blog.DataLayer/ Blog.DataLayer/

WORKDIR /src/Blog

# Build the project
RUN dotnet build Blog.csproj -c $BUILD_CONFIGURATION -o /app/build

# Stage 3: Publish
FROM build AS publish
RUN dotnet publish Blog.csproj -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Final Image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

# نصب netcat برای چک کردن وضعیت SQL Server
RUN apt-get update && apt-get install -y netcat-openbsd

# دادن مجوز اجرایی به entrypoint.sh
COPY Blog/entrypoint.sh ./entrypoint.sh
RUN chmod +x ./entrypoint.sh

# اجرای اپلیکیشن با استفاده از entrypoint.sh
ENTRYPOINT ["./entrypoint.sh"]
