using Business.Abstract;
using DataAccess.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult GetAll()
        { 
           
            var result = _imageService.GetAll();   
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _imageService.Get(id);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("upload")]
        public IActionResult Upload([FromForm(Name ="Image")] IFormFile file , [FromForm] Image image)
        {
            
          
            var result =_imageService.Upload(file,image);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
           
        }
        [HttpDelete("delete")]
        public IActionResult Delete(Image image)
        {
            var result = _imageService.Delete(image);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update([FromForm(Name ="Image")] IFormFile file,[FromForm] Image image)
        {
            var result = _imageService.Update(file,image);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}