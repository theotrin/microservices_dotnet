FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /app
COPY *.csproj ./
RUN dotnet restore
COPY . ./
RUN dotnet publish -d Relase -o out
ENTRYPOINT [ "dotnet", "ItemService.dll" ]