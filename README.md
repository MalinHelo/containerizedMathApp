# containerizedMathApp
Docker - containerized .NET app

### Project Description
This small project was made for me to practice how to containerize a .NET app for Docker.

### How to install
You will need to install the following programs if you don't have them:
- Visual Studio Code
  https://code.visualstudio.com/download
- Docker desktop
  https://www.docker.com/products/docker-desktop/

### Run the program
1.  Start Visual Studio Code
2.  Clone the repo
   
   1.1 Copy the shortcut in GitHub
   ![image](https://github.com/MalinHelo/containerizedMathApp/assets/130759636/eb6628da-a0e6-4309-9e6a-c2dbc5ba4101)
   1.2 In Visual Studio Code -> Clone Git Repository -> Past the shortcut -> Select destination for the             repository -> open the cloned repository.
   
3.  Start Docker Desktop
4.  In Visual Studio terminal runt the following commands in this order:
   
    4.1
    ```
    cd App
    ```
    4.2
    ```
    dotnet publish -c Release
    ```
    4.3
    Build the image in docker
    ```
    docker build -t math-image -f Dockerfile .
    ```
    4.4
    If you want to you can run this code to check if the image you builded exsits. You will see a list of      all the images that are installed.
    ```
    docker images
    ```
    4.5
    Create the container based on the image you just created.
    We use the -it command before the name becaus we want the projekt to run forever, or until we stop it.
    ```
    docker create -it --name math-container math-image
    ```
    4.6
    To see a list of all containers
    ```
    docker ps -a
    ```
    4.7
    To start the container
    ```
    docker start math-container
    ```
    4.8
    To stop the container
    ```
    docker stop math-container
    ```
### Docker
In Docker Desktop you can check if the images and containers exsits. It's also a good idea to check        the logs.
