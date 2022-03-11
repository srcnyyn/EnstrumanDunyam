using Business.Abstract;
using DataAccess.Entities.Concrete;
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

            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("getbybrandid")]
        public IActionResult GetByBrandId(int id)
        {

            var result = _productService.GetByBrandId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbycategoryid")]
        public IActionResult GetByCategoryId(int id)
        {

            var result = _productService.GetByCategoryId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbychildcategoryid")]
        public IActionResult GetByChildCategoryId(int id)
        {

            var result = _productService.GetByChildCategoryId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbycolorid")]
        public IActionResult GetByColorId(int id)
        {

            var result = _productService.GetByColorId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyproductid")]
        public IActionResult GetByProductId(int id)
        {
            var result = _productService.GetByProductId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Product product)
        {

            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);



        }
        [HttpDelete("delete")]
        public IActionResult Delete(Product product)
        {

            var result = _productService.Delete(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Update(Product product)
        {

            var result = _productService.Update(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}