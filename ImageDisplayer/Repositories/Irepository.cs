using System.Collections;
using ImageDisplayer.Models;

namespace ImageDisplayer.Repositories;
public interface IRepository
{
  Task<List<ImageURL>> GetImageURLs();
  Task<ImageURL> GetImageById(int id);
}