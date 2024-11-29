using System.Collections;
using ImageDisplayer.Models;
using Microsoft.EntityFrameworkCore;

namespace ImageDisplayer.Repositories;
 
 public class Repository : IRepository
 {
    private readonly ImageDisplayerDbContext _dbContext ;
    public Repository(ImageDisplayerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<ImageURL>> GetImageURLs()
    {
         return await  _dbContext.ImageURLs.ToListAsync();
       
    }
        
     public async Task<ImageURL> GetImageById(int id)
    {
         return await  _dbContext.ImageURLs?.Where(i => i.Id == id).FirstOrDefaultAsync();
    }
}
 
