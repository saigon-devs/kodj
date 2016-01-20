# kodj simple service
This is a very simple service leverage the latest .NET Core technology. It includes:
* Kodj.Service: a very simple service
* Kodj.API: service enpoint

## Features
* Cross-platform (MacOS, Windows, Linux, Docker, Azure, Amazon...)
* Docker compatible
* Be able to scale smoothly
* Appropriate to be a microservice

## How to run
* Clone the source code to your local computer
* Go to Kodj.Api folder and run this commands to restore packages, create database and starting the web
```
dnu restore
dnx ef database update
dnx web
```