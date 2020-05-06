FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["InterviewFront/InterviewFront.csproj", "InterviewFront/"]
RUN dotnet restore "InterviewFront/InterviewFront.csproj"
COPY . .
WORKDIR "/src/InterviewFront"
RUN dotnet build "InterviewFront.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "InterviewFront.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "InterviewFront.dll"]