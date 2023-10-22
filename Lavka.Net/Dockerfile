FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Lavka.Net/Lavka.Net.csproj", "Lavka.Net/"]
RUN dotnet restore "Lavka.Net/Lavka.Net.csproj"
COPY . .
WORKDIR "/src/Lavka.Net"
RUN dotnet build "Lavka.Net.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Lavka.Net.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Lavka.Net.dll"]
