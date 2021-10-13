node {
    stage ('Repositorio'){
        git branch: 'main', credentialsId: 'a864bf7a-4fc5-4e56-8ffe-aaf6a18caa80', url: 'https://github.com/capy-larit/challengeDevops'
    }
    stage('Login'){
        az login --service-principal --username '05b77a75-d0ff-46af-85b8-007aa17f1bb0' --password 'xXW..9Hb~wqO6QdMYeqZvy17th_-EVp.ht' --tenant '11dbbfe2-89b8-4549-be10-cec364e59551'
    }
    
    
      
    stage('Build') {
        echo 'acesse -> https://testjenkins.azurewebsites.net/ teste'
    }


}
