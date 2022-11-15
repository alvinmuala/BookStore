# BookStore

The project contains a .NET 6 WEB API using a token-based authentication and autorization and an Angular 14 Web UI that can be used to login, register as a user and access a  book catalogue. 

Please follow the steps below to test and run the solution:

1.Open the .NET 6 Solution in Visual Studio, open your package manager console and run the command "Update-Database" to create and seed a local sql server database using  EF core. Once the database is created and all the seed data have been added, launch the solution in debug mode to access the API swagger interface. 
You will need to first register a user in order to generate a JWT token and pass it to the header (e.g: Bearer <mytoken>) to access all the non-public API endpoints.


2.To run the angular web UI, you will need to install Node.js — https://nodejs.org/en/ on your computer as well as Angular 14 — https://angular.io/guide/setup-local#install-the-angular-cli. 

Open a powershell window and navigate to the folder BookStore.App and run the command "npm install" to install all the required npm packages for the solution. 
Once the packages are installed, run the command "ng serve" to launch the Web UI. The web UI app has been configured to run on http://localhost:4200. 
 
 For local testing, please run the WEB API and the WEB UI concurrently. 
  
 
