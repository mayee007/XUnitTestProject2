pipeline {
    agent any  
    environment {
        FILE = "packageList.txt"
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
		    bat "dir documents\\${FILE}"
		    bat "dotnet list package>${FILE}"
            }
        }
		stage('Verify') {
			steps { 
				bat "type ${FILE}"
				bat "fc /a ${FILE} documents\\${FILE}"   
			}
		}		
    } // end of all stages 
} // end of pipeline 
