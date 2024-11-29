using System.ComponentModel.DataAnnotations.Schema;
namespace ImageDisplayer.Models;
[Table("images")]
public class ImageURL
{
   public int Id { get; set; }
   public string? URL { get; set; }
}