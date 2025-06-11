using Microsoft.EntityFrameworkCore;
using Repository;

var builder = WebApplication.CreateBuilder(args);

// Get the connection string from appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Register the DbContext with the connection string
builder.Services.AddDbContext<TOKDBContext>(options =>
    options.UseNpgsql(connectionString));

var app = builder.Build();

app.Run();