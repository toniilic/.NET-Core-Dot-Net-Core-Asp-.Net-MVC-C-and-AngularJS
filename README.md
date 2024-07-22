# .NET Core and Angular Full Stack Project

This project demonstrates a full-stack application using .NET Core for the backend API and Angular for the frontend.

## Features
- ASP.NET Core Web API
- Entity Framework Core with SQL Server
- Angular frontend with Material UI
- CRUD operations
- Authentication and Authorization (JWT)
- Complex SQL queries demonstration
- Swagger API documentation

## Prerequisites
- .NET Core SDK
- Node.js and npm
- SQL Server

## Setup
1. Clone the repository
2. Navigate to the API project and run `dotnet restore`
3. Navigate to the Angular project and run `npm install`
4. Update the connection string in `appsettings.json`
5. Run the API project with `dotnet run`
6. Run the Angular project with `ng serve`

## API Endpoints
- GET /api/samples
- POST /api/samples
- PUT /api/samples/{id}
- DELETE /api/samples/{id}

## Authentication
This project uses JWT for authentication. To get a token, send a POST request to /api/auth/login with your credentials.

## Author
Toni Ilić

