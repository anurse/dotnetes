﻿FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
ENV ASPNETCORE_URLS http://*:80
WORKDIR /app
COPY . /app
ENTRYPOINT [ "dotnet", "!APPDLL!" ]