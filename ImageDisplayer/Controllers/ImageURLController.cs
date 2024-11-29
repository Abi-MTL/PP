using Microsoft.AspNetCore.Mvc;
using ImageDisplayer.Services;
namespace ImageDisplayer.Controllers ;

[ApiController]
[Route("[controller]")]
public class ImageURLController : ControllerBase
{
      private readonly IImageProvider _imageProvider ;
    public ImageURLController(IImageProvider imageProvider)
    {
        _imageProvider = imageProvider;
    }

  

   [HttpGet]   // GET /api/test2/xyz
    public async Task<IActionResult> GetUrl([FromQuery] string userIdentifier)
    {
            var result = new URLResultDTO();
            try 
            {
                 result.ErrorMEssage = "";
                 result.HasError = false;
                 result.URL = await _imageProvider.GetImage(userIdentifier);
            }
            catch (Exception ex)
            {
                result.ErrorMEssage = ex.Message;
                result.HasError = true;
                result.URL = "";
            }

            return Ok(result); 
       
    }
}