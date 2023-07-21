# Movie Recommendations Exercise
**Exercise premise:** You are tasked with developing a movie recommendation system using .NET and C#. The system should be able to recommend which movies a user can watch, using a simple random criteria over a collection of movies. The importance of this exercise is to implement a fully working Rest API solution, which is able to handle the creation of Users, creation of Movies, and to provide the said logic to recommend movies.

The importance of this exercise is to implement a fully working Rest API solution, which is able to handle the creation of Users, creation of Movies, and to provide the said logic to recommend movies.

**More CRUD operations are welcome!** Feel free to contribute to this repository with your examples, and practice during the process!

This is a practical exercise to improve your coding skills in terms of
- Coding best practices
- Usage of design patterns
- Use of modern libraries
  

# Specific Features
- Users can create a new movie entry.
- Users can create a new user profile.
- Users can get a list of recommended movies based on their interests.

# Technologies Used
- .NET and C# for the backend implementation
- ASP.NET Core for building the RESTful API
- Clean Architecture
- Entity Framework Core for database access (Repository pattern)
- MediatR for implementing the mediator pattern
- FluentValidation for model validation
- SQL Server for the database

# Getting Started

**1. Clone the repository:**

``` cs
git clone https://github.com/your-username/movie-recommendation-system.git
```
**2. Open the solution**

**3. Update the database connection string in the appsettings.json file under the MovieRecommendation.API project.**

**4. Run the database migrations to create the necessary database schema:**

```cs
dotnet ef database update
```

**5. Use a REST client (such as Postman) to interact with the API endpoints.**

# API Endpoints
- **POST /movies:** Create a new movie.
- **POST /users:** Create a new user profile.
- **GET /users/{userId}/recommended:** Get a list of recommended movies for a specific user.

# Contributing
Contributions are welcome! If you'd like to contribute to this project, please follow these steps:

- Fork the repository.
- Create a new branch for your feature or bug fix.
- Implement your changes.
- Open a pull request, describing your changes and the problem they solve.


