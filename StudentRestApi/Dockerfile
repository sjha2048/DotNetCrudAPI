FROM mcr.microsoft.com/dotnet/sdk:3.1 AS buid-env

WORKDIR /app

COPY *.csproj ./

RUN dotnet restore

COPY . ./ 

RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/sdk:3.1

WORKDIR /app
EXPOSE 80
COPY --from=buid-env /app/out .
ENTRYPOINT ["dotnet", "StudentRestApi.dll"]         