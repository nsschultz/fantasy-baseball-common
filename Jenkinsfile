pipeline {
    agent { label 'builder' }
    environment {
        VERSION_NUMBER = '0.5.3'
        IMAGE_VERSION = "${GIT_BRANCH == "main" ? VERSION_NUMBER : VERSION_NUMBER+"-"+GIT_BRANCH}"
        DOCKER_HUB = credentials("dockerhub-creds")
    }
    stages {
        stage('build and publish') { 
            steps { script { sh  """
                #!/bin/bash
                docker build -t nschultz/fantasy-baseball-common-models:${IMAGE_VERSION} .
                docker login -u ${DOCKER_HUB_USR} -p ${DOCKER_HUB_PSW}
                docker push nschultz/fantasy-baseball-common-models:${IMAGE_VERSION}
                docker logout
            """ } } 
        }
    }
    post { always { script { sh("docker builder prune -f --filter \'unused-for=24h\'") } } }
}