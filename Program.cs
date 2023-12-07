using Microsoft.EntityFrameworkCore;
using MusicApp.Data;
using MusicApp.Repositories;
using MusicApp.Repositories.Interfaces;
using MusicApp.Services;
using MusicApp.Services.Interfaces;


var builder = WebApplication.CreateBuilder(args);
//configure the database
builder.Services.AddDbContext<AppDbContext>(options=>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
//configure repo and services
builder.Services.AddScoped<IArtistRepository, ArtistRepository>();
builder.Services.AddScoped<IArtistService, ArtistService>();

builder.Services.AddControllers();
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
app.UseAuthorization();

app.MapControllers();


app.Run();

