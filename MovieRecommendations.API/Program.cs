using FluentValidation;
using Microsoft.EntityFrameworkCore;
using MovieRecommendations.Application.DependencyInjection;
using MovieRecommendations.Application.Validators;
using MovieRecommendations.Domain.Interfaces;
using MovieRecommendations.Domain.Services;
using MovieRecommendations.Infrastructure;
using MovieRecommendations.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MovieDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("moviesdb")));

builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IRecommendationAlgorithm, RecommendationAlgorithm>();

builder.Services.AddScoped<IValidator, GetRecommendedMoviesQueryValidator>();

builder.Services.AddMediatRServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
