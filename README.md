# MovieReviewAPI

A simple ASP.NET Core Web API project for managing movies and user reviews.

---

## Features

- Add, update, delete movies
- Add reviews with rating (1–5)
- View all movies
- View all reviews
- Swagger API documentation

---

## Tech Stack

- ASP.NET Core Web API
- Entity Framework Core (InMemory Database)
- C#
- Swagger (Swashbuckle)

---

## Project Structure

MovieReviewApi/
├── Controllers/
│   ├── MoviesController.cs
│   └── ReviewsController.cs
│
├── Models/
│   ├── Movie.cs
│   └── Review.cs
│
├── Data/
│   └── AppDbContext.cs
│
├── Program.cs
└── MovieReviewApi.csproj

---

## How to Run

### 1. Restore packages
dotnet restore

### 2. Run the project
dotnet run

### 3. Open Swagger
http://localhost:5000/swagger

---

## API Endpoints

### Movies

GET /api/Movies
POST /api/Movies

### Reviews

GET /api/Reviews
POST /api/Reviews

---

## Sample JSON

### Add Movie
{
  "title": "Inception",
  "genre": "Sci-Fi",
  "releaseYear": 2010
}

### Add Review
{
  "movieId": 1,
  "comment": "Amazing movie!",
  "rating": 5
}

---

## Future Improvements

- Add JWT Authentication
- Use SQL Server database
- Add pagination and filtering
- Calculate average movie ratings
- Add user system

---

## Author

ASP.NET Core Web API Portfolio Project
