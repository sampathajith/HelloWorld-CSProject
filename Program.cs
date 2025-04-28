using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGet("/", () => "Hello, World!");

// Explicitly configure the application to listen on port 80
app.Urls.Add("http://0.0.0.0:80");

app.Run();