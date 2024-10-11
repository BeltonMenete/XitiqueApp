using Microsoft.EntityFrameworkCore;
using XitiqueAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Connection String Configurations
var postgres = builder.Configuration.GetConnectionString("postgres");
builder.Services.AddDbContext<AppDbContext>((options) => options.UseNpgsql(postgres));

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();
