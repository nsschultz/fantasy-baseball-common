# syntax=docker/dockerfile:experimental
FROM nschultz/sdk-with-scanner:0.5.3 AS common-models-build
COPY . /app
ENV MAIN_PROJ=FantasyBaseball.CommonModels \
    SONAR_KEY=fantasy-baseball-common-models
RUN --mount=type=cache,id=sonarqube,target=/root/.sonar/cache ./build.sh

FROM nschultz/sdk-with-scanner:0.5.3
COPY --from=common-models-build /app/out /libs/
WORKDIR /app