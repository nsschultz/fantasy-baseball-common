# syntax=docker/dockerfile:experimental
FROM nschultz/base-csharp-builder:5.0.102 AS build
COPY . /app
ENV MAIN_PROJ=FantasyBaseball.CommonModels \
    SONAR_KEY=fantasy-baseball-common-models
RUN --mount=type=cache,id=sonarqube,target=/root/.sonar/cache ./build.sh

FROM nschultz/base-csharp-builder:5.0.102
COPY --from=build /app/out /libs/
WORKDIR /app