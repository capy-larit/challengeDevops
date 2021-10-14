node {
    withCredentials([azureServicePrincipal('azsrvprincipal')]){
        sh 'echo acesse teste'
        sh 'ls'
        sh 'az webapp up --sku F1 --name testJenkins --os-type linux'
    }
    
    stage('Build') {
        echo 'acesse -> https://testjenkins.azurewebsites.net/ teste'
    }


}
