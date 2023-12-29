# Beginner-Project-ToDoApp
A simple "ToDoApp" project developed with Asp.NetCore Mvc WebAPI

___

# To Do
ToDo app is a general to-do program with user security and access authentication, which can be categorized, creates a list with dates and to-dos, and performs certain API operations from this list.

# Deployment 
Open VS (Visual Studio) 2022, create a `repository clone` using the link of this repository on GitHub.


# Todo Client

This project was built with [Swagger swashbuckle.aspnetcore](https://github.com/domaindrivendev/Swashbuckle.AspNetCore) version 6.2.3.

## Working APIs;

### Authentication

POST: Registration, Authenticate, Refresh

### Chapter (All Categories:AC)(One Category:OC)

GET: AC, OC, OC with Invalid Id

### Tasks (All Books:AB)(One Book:OB)

GET: 
AB, AB with Pagination, AB with Details, AB with Filtering, AB with Search, AB with Order, AB with Data Shaping, AB with Links, OB, AB with Invalid Id

POST: OB, OB with Invalid Object

HEAD: Head

OPT: Options

DEL: OB

PUT: OB, OB with Invalid Object

PATCH: OB DateTime, OB with Invalid Object

## Development server

Run `Visual Studio 2022` for a dev server. Navigate to `https://localhost:7077/swagger/index.html`.


## Build

Run `VS (Visual Studio) 2022 build` to build the project or press `F6`. To create a database, open the `NuGet Package Manager` console and run the `update-databese` command. The build artifacts will be stored in the `ToDoApp/` directory.

## Running unit tests

Run `Visual Studio ToDo WebApi` to execute the unit tests via [Postman](https://documenter.getpostman.com/view/27682287/2s93shzpGE/).

## Running end-to-end tests

Run `Visual Studio ToDo WebApi` to execute the end-to-end tests via [Postman](https://documenter.getpostman.com/view/27682287/2s93shzpGE/).

## Further help

To get more help on the Asp.NetCore Mvc use `Asp.NetCore Mvc help` or go check out the [.Net aspnetcore](https://github.com/dotnet/aspnetcore).

