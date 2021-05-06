pipeline {
    agent any 
    environment {
        FILE = "newPackageList.txt"
        DOTNET = "C:\\Program Files\\dotnet\\dotnet.exe"
    }
    
    stages {
        stage('checkout') {
            steps {
					git branch: 'main', url: 'https://github.com/mayee007/XUnitTestProject2.git'
				}
        } 
		 
        stage('Build') {
            steps {
		    bat "dir"
		    bat "dir documents"
		    bat "dir documents\\packageList.txt"
		    bat "dotnet list package>${FILE}"
            }
        }
		stage('Verify') {
			steps { 
				bat "type ${FILE}"
				bat "fc /a newPackageList.txt documents\\packageList.txt > nul"
   
			}
		}
		
    }
}
