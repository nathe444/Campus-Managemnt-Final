using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using CampusManagementSystem;
using Microsoft.OpenApi.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSingleton<MongoDBContext>();

var app = builder.Build();




app.UseHttpsRedirection();



// Test MongoDB connection
var mongoContext = app.Services.GetRequiredService<MongoDBContext>();
var isConnected = await mongoContext.TestConnection();
if (isConnected)
{
    Console.WriteLine("Successfully connected to MongoDB!");
}
else
{
    Console.WriteLine("Failed to connect to MongoDB. Please check your connection string and ensure MongoDB is running.");
}

app.Run();

