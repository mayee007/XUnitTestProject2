def getEnvFromBranch(branch) {
  if (branch == 'master') {
    return 'production'
  } else if (branch == 'test1') {
    return 'development' 
 } else { 
	return 'staging'
 }
 
}

pipeline {
    agent any 
    environment {
        nexus_ver = "something-${env.BUILD_NUMBER}"
        SUBDIR = "dir1/subdir/subsubdir"
        SUBDIR_WIN = "${env.WORKSPACE}\\dir1\\subdir\\subsubdir"
        DOTNET = "C:\\Program Files\\dotnet\\dotnet.exe"
		DEPLOY_ENV = getEnvFromBranch(env.BRANCH_NAME)
		SECONDARY_VAR = 'something-${DEPLOY_ENV}-end'
    }
    
    stages {
        stage('checkout') {
            steps {
					git 'https://github.com/mayee007/XUnitTestProject2.git'
				}
        } 
		 
        stage('Build') {
            steps {
                bat 'dotnet list package>new_packages.txt'
            }
        }
		stage('Verify') {
			steps { 
				bat "type new_packages.txt"
			}
		}
		
    }
}
