using BlogApp.Data.Concrete.EfCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<BlogContext>(options =>
{
    var config = builder.Configuration;
    var connectionString = config.GetConnectionString("mssql_connection");
    options.UseSqlServer(connectionString);
});

var app = builder.Build();

// Seed data is loaded when the project runs.
SeedData.FillTestData(app);

app.MapDefaultControllerRoute();

app.Run();
