using System;
using System.Collections.Generic;
using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace EDAPI.Controller
{
    [ApiController]
    [Route("[controller]")]

    public class ProductController : ControllerBase
    {
        IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
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
            return Ok(result);

        }
        [HttpGet("getbybrandid")]
        public IActionResult GetByBrandId(int id)
        {
            List<Product> result = new List<Product>();
            try
            {
                result = _productService.GetByBrandId(id);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
            return Ok(result);
        }
        [HttpGet("getbycategoryid")]
        public IActionResult GetByCategoryId(int id)
        {
            List<Product> result = new List<Product>();
            try
            {
                result = _productService.GetByCategoryId(id);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
            return Ok(result);
        }
        [HttpGet("getbychildcategoryid")]
        public IActionResult GetByChildCategoryId(int id)
        {
            List<Product> result = new List<Product>();
            try
            {
                result = _productService.GetByChildCategoryId(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            return Ok(result);
        }
        [HttpGet("getbycolorid")]
        public IActionResult GetByColorId(int id)
        {
            List<Product> result = new List<Product>();
            try
            {
                result = _productService.GetByColorId(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            return Ok(result);
        }
        [HttpGet("getbyproductid")]
        public IActionResult GetByProductId(int id)
        {
            Product result = new Product();
            try
            {
                result = _productService.GetByProductId(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            return Ok(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            try
            {
                _productService.Add(product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            return Ok();
        }
        [HttpDelete("delete")]
        public IActionResult Delete(Product product)
        {
            try
            {
                //Product deletedProduct = new Product();
                //deletedProduct = _productService.GetByProductId(id);
                _productService.Delete(product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            return Ok();
        }
        [HttpPut("update")]
        public IActionResult Update(Product product)
        {
            try
            {
                _productService.Update(product);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
            return Ok();
        }
    }
}