pipeline {
    agent any 
    environment {
        FILE = "new_packages.txt"
        DOTNET = "C:\\Program Files\\dotnet\\dotnet.exe"
    }
    
    stages {
        stage('checkout') {
            steps {
					git 'https://github.com/mayee007/XUnitTestProject2.git'
				}
        } 
		 
        stage('Build') {
            steps {
		    bat "dir"
		    bat "documents"
		    bat "dir documents\\packageList.txt"
		    bat "dotnet list package>${FILE}"
            }
        }
		stage('Verify') {
			steps { 
				bat "type ${FILE}"
			}
		}
		
    }
}
