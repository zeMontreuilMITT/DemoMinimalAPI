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

app.MapGet("/cities", async (int? population, WorldContext db) =>
{
    if(population != null)
    {
        return await db.Cities.Where(c => c.Population >= population).ToListAsync();
    }
    return await db.Cities.ToListAsync();
});

app.MapGet("/cities/{id}", async (int id, WorldContext db) =>
{
    return await db.Cities.FirstAsync(c => c.Id == id);
});

app.Run();
