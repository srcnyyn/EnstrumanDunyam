using System;
using System.Collections.Generic;
using System.IO;
using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EDAPI.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class ImageController : ControllerBase
    {
        IImageService _imageService;

        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }

        [HttpGet]
        public IActionResult GetAll()
        { var images = new List<Image>();
            try
            {
             images = _imageService.GetAll();   
            }
            catch (Exception ex)
            {
                
                return  BadRequest(ex);
            }
            return Ok(images);
        }
        [HttpPost]
        public IActionResult Upload([FromForm(Name ="Image")] IFormFile file , [FromForm] Image image)
        {
            
            try
            {
            _imageService.Upload(file,image);
            }
            catch (Exception ex)
            {
                
                return BadRequest(ex);
            }
            return Ok();
           
           
        }
    }
}