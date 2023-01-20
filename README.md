# _Travel Api_

#### By: _**David Gamble**_

#### _Files, Code, and setup with comments for using Identity and Roles to add to projects._

## Technologies Used



* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)_
* [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
* [MySQL](https://dev.mysql.com/)
* [Entity Framework Core 6.0.0](https://docs.microsoft.com/en-us/ef/core/)
* [Swagger](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-nswag?view=aspnetcore-3.1&tabs=visual-studio)
* [Postman](postman.com)


### Description
An API that functions as a recipe archive for coffee drinks from around the world. It utilizes RESTful principles, version control, pagination, and has integrated authentication to keep the API Read-Only for all users except administrators. The user is able to see the in-use version of the API when using Postman.

## Setup/Installation Requirements

* _Clone the repository to your desktop from: https://github.com/DavidDGamble/TravelApi.Solution.git_
* _Create appsettings.json file in ASPNETIdentityRoles folder_

```
{
    "Logging": {
      "LogLevel": {
        "Default": "Information",
        "Microsoft.AspNetCore": "Warning"
      }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE_NAME];uid=[USERNAME];pwd=[PASSWORD];"
    }
  }

```
* _run dotnet commands below in _TravelApi_
```
dotnet restore
```
```
dotnet ef database update
```
```
dotnet watch run
```
 #### Launch the API
  1) Navigate to TravelApi.Solution/TravelApi directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/TravelApi.Solution/TravelApi`).
  2) Run the command `dotnet run` to have access to the API in Postman or browser.

------------------------------

## API Documentation
Explore the API endpoints in Postman or a browser. You will not be able to utilize authentication in a browser.

### Using Swagger Documentation 
To explore the Travel-Api with NSwag, launch the project using `dotnet run` with the Terminal or Powershell, and input the following URL into your browser: `http://localhost:5000/swagger`

### Endpoints
Base URL: `https://localhost:5000`

#### HTTP Request Structure
```
GET /api/{component}
PUT /api/{component}
DELETE /api/{component}/{id}
GET /api/{component}/{id}
POST /api/{component}/{id}
```

#### Example Query

```
https://localhost:5001/api/Destinations/1

```

#### Sample JSON Response
``` {
  "destinationId": 1,
  "name": "portland",
  "reviews": null
} 
```

#### Example Query

```
https://localhost:5001/api/Reviews/5

```
#### Sample JSON Response
``` 
{
  "reviewId": 5,
  "summary": "gresham sucks",
  "rating": 2,
  "destinationId": 2
}
```

## Known Bugs

* _No known issues_

## License

_Copyright (c) 2022 David Gamble_

_Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:_

_The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software._

_THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE._
