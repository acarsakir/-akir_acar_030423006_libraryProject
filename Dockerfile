FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app


COPY ./businessLayer ./businessLayer
COPY ./dataAccessLayer ./dataAccessLayer
COPY ./entityLayer ./entityLayer
COPY ./şakir_acar_030423006_libraryProject ./şakir_acar_030423006_libraryProject

RUN dotnet restore ./şakir_acar_030423006_libraryProject/şakir_acar_030423006_libraryProject.csproj
RUN dotnet publish şakir_acar_030423006_libraryProject/şakir_acar_030423006_libraryProject.csproj -c Release -o /out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /out .

EXPOSE 80
ENTRYPOINT ["dotnet", "şakir_acar_030423006_libraryProject.dll"]