using ImageDisplayer.Models;
using Microsoft.EntityFrameworkCore;

namespace ImageDisplayer.Repositories;
public class ImageDisplayerDbContext : DbContext
{
    public ImageDisplayerDbContext(DbContextOptions<ImageDisplayerDbContext> options) : base(options) { }
    public DbSet<ImageURL>? ImageURLs { get; set; }

 
}