# syntax=docker/dockerfile:experimental
FROM nschultz/base-csharp-builder:5.0.102 AS build-exceptions
COPY Exceptions/ /app
ENV MAIN_PROJ=FantasyBaseball.Common.Exceptions \
    SONAR_KEY=fantasy-baseball-common-exceptions
RUN --mount=type=cache,id=sonarqube,target=/root/.sonar/cache ./build.sh

FROM nschultz/base-csharp-builder:5.0.102
COPY --from=build-exceptions /app/out /libs/
WORKDIR /app