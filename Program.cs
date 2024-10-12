using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using xitiqueAPI;
using XitiqueAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Get the connection string from configuration
var connString = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.
builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(MapConfig));

// Add the DbContext using the connection string (PostgreSQL in this case)
builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connString));

// Configure Swagger/OpenAPI
builder.Services.AddSwaggerGen();  // Correct method for adding Swagger

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
    app.UseSwagger();   // Enable Swagger middleware
    app.UseSwaggerUI(); // Enable Swagger UI
}

app.UseHttpsRedirection();

app.MapControllers();  // Ensure controllers are mapped correctly

app.Run();
