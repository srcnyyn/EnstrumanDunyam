using System;
using System.Collections.Generic;
using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace EDAPI.Controller
{
    [ApiController]
    [Route("[controller]")]

    public class ProductController:ControllerBase
    {
        IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Product> result = new List<Product>();
            try
            {
            result = _productService.GetAll();
                
            }
            catch (Exception ex)
            {
                
                return BadRequest(ex);
            }
            return  Ok(result);
            
        }
    }
}