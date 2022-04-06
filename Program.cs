using DemoApi.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<WorldContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WorldDatabase"))
);

var app = builder.Build();

app.MapGet("/countries", async (WorldContext db) =>
{
    return await db.Countries.ToListAsync();
});

app.MapGet("/cities", async (WorldContext db) =>
{
    return await db.Cities.ToListAsync();
});

app.Run();
