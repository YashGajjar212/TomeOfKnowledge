using Books.Integration.Interface;
using Books.Integration.Service;
using Microsoft.EntityFrameworkCore;
using Repository;

var builder = WebApplication.CreateBuilder(args);

// Get the connection string from appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Register the DbContext with the connection string
builder.Services.AddDbContext<TOKDBContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddControllersWithViews();

// Register methods for Dependency Injection
builder.Services.AddScoped<IGetAllBooks, GetAllBooksService>();

var app = builder.Build();

app.MapControllerRoute(
    name: "Book",
    pattern: "{controller=Book}/{action=GetAllBooks}/{id?}"
    );

app.Run();