node {
    stage ('Repositorio'){
        git branch: 'main', credentialsId: 'a864bf7a-4fc5-4e56-8ffe-aaf6a18caa80', url: 'https://github.com/capy-larit/challengeDevops'
    }
    withCredentials([azureServicePrincipal('azsrvprincipal')]) 
    
    
    
      
    stage('Build') {
        echo 'acesse -> https://testjenkins.azurewebsites.net/ teste'
    }


}
