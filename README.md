# WFA - Windows Froms Application

## 1. Introduction
This is a college project from a program egineering course. We had a task to represent 3-tier architecture in a windows form application. 
We chose a local private medical clinic to build a simple CRUD application. The name of our team was "HouseMed" team and so are the 
names of our projects

## 2. The architecture
We've devided the application into 3 layers and each layer represents a project

- HouseMed project represents Presentation layer
- HouseMed.BAL project represents Business access layer
- HouseMed.DAL project represents Data access layer

##3. DAL - Data access layer
In the DAL we are using EntityFramework to comunicate with the database and 
all the database entities are on Croatian language so if there are any foreign readers sorry in advance (use google translate).

Run the DatabaseScript to create the entities in a desired database management studio and change the App.config to your host in your visual studio on HouseMed and HouseMed.DAL projects. 

## 4. Presentation layer

#### LoadingScreen.dll
Between our main files you can find a .dll named "LoadingScreen". It's a simple dll which contains random 
images and circulates these images.
The problem is the project won't work if you don't add that file as a reference into HouseMed project so follow the 
"Download the project steps carefully".

## 5. Download the project
To make this application work follow these steps:

1. Download the project in zip format
2. Use the Database script to create the database in your desired database management studio (We were using Microsoft SQL Server Management Studio).
3. Use google translate to find out which entities are which and add some data in the database.
4. Open the project in Visual Studio
5. Set the database connections in your App.Configs
6. Add LoadingScreen.dll as a reference in HouseMed project 
7. Run the solution


