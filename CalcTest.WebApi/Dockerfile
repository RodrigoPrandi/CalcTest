FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 1468
EXPOSE 44372

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["CalcTest.WebApi/CalcTest.WebApi.csproj", "CalcTest.WebApi/"]
COPY ["CalcTest.Infra.CrossCutting/CalcTest.Infra.CrossCutting.csproj", "CalcTest.Infra.CrossCutting/"]
COPY ["CalcTest.Domain/CalcTest.Domain.csproj", "CalcTest.Domain/"]
COPY ["CalcTest.Infra.Data.InMemory/CalcTest.Infra.Data.InMemory.csproj", "CalcTest.Infra.Data.InMemory/"]
COPY ["CalcTest.Application/CalcTest.Application.csproj", "CalcTest.Application/"]
RUN dotnet restore "CalcTest.WebApi/CalcTest.WebApi.csproj"
COPY . .
WORKDIR "/src/CalcTest.WebApi"
RUN dotnet build "CalcTest.WebApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "CalcTest.WebApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CalcTest.WebApi.dll"]