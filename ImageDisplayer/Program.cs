using ImageDisplayer.Repositories;
using ImageDisplayer.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IImageProvider, ImageProvider>();
builder.Services.AddTransient<IRepository, Repository>();
builder.Services.AddDbContext<ImageDisplayerDbContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("ImageURLDB")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();

