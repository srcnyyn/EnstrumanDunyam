using Business.Abstract;
using DataAccess.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EDAPI.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImageController : ControllerBase
    {
        IImageService _imageService;

        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAllAsync()
        { 
           
            var result = await _imageService.GetAllAsync();   
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var result = await _imageService.GetAsync(id);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("upload")]
        public async Task<IActionResult> UploadAsync([FromForm(Name ="Image")] IFormFile file , [FromForm] Image image)
        {
            
          
            var result = await _imageService.UploadAsync(file,image);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
           
        }
        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteAsync(Image image)
        {
            var result = await _imageService.DeleteAsync(image);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public async Task<IActionResult> UpdateAsync([FromForm(Name ="Image")] IFormFile file,[FromForm] Image image)
        {
            var result = await _imageService.UpdateAsync(file,image);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}