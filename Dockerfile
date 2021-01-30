# syntax=docker/dockerfile:experimental
FROM nschultz/base-csharp-builder:5.0.102 AS build-enums
COPY fantasy-baseball-common-enums.sln /app
COPY FantasyBaseball.Common.Enums/ /app/FantasyBaseball.Common.Enums
COPY FantasyBaseball.Common.Enums.UnitTests/ /app/FantasyBaseball.Common.Enums.UnitTests
ENV MAIN_PROJ=FantasyBaseball.Common.Enums \
    SONAR_KEY=fantasy-baseball-common-enums
RUN --mount=type=cache,id=sonarqube,target=/root/.sonar/cache ./build.sh

FROM nschultz/base-csharp-builder:5.0.102 AS build-exceptions
COPY fantasy-baseball-common-exceptions.sln /app
COPY FantasyBaseball.Common.Exceptions/ /app/FantasyBaseball.Common.Exceptions
COPY FantasyBaseball.Common.Exceptions.UnitTests/ /app/FantasyBaseball.Common.Exceptions.UnitTests
ENV MAIN_PROJ=FantasyBaseball.Common.Exceptions \
    SONAR_KEY=fantasy-baseball-common-exceptions
RUN --mount=type=cache,id=sonarqube,target=/root/.sonar/cache ./build.sh

FROM nschultz/base-csharp-builder:5.0.102
COPY --from=build-enums /app/out /libs/
COPY --from=build-exceptions /app/out /libs/
WORKDIR /app