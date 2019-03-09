FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["LicenceKeysAPI/LicenceKeysAPI.csproj", "LicenceKeysAPI/"]
RUN dotnet restore "LicenceKeysAPI/LicenceKeysAPI.csproj"
COPY . .
WORKDIR "/src/LicenceKeysAPI"
RUN dotnet build "LicenceKeysAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "LicenceKeysAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "LicenceKeysAPI.dll"]