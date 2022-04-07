using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Entities.Concrete;
using DataAccess.Entities.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EDAPI.Controller
{
    [ApiController]
    [Route("api/[controller]")]

    public class ProductController : ControllerBase
    {
       
        IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
            
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAllAsync()
        {

            var result = await _productService.GetAllAsync();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("getbybrandid")]
        public async Task<IActionResult> GetByBrandIdAsync(int id)
        {

            var result = await _productService.GetByBrandIdAsync(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbycategoryid")]
        public async Task<IActionResult> GetByCategoryIdAsync(int id)
        {

            var result = await _productService.GetByCategoryIdAsync(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbychildcategoryid")]
        public async Task<IActionResult> GetByChildCategoryIdAsync(int id)
        {

            var result = await _productService.GetByChildCategoryIdAsync(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbycolorid")]
        public async Task<IActionResult> GetByColorIdAsync(int id)
        {

            var result = await _productService.GetByColorIdAsync(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyproductid")]
        public async Task<IActionResult> GetByProductIdAsync(int id)
        {
            var result = await _productService.GetByProductIdAsync(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public async Task<IActionResult> AddAsync(Product product)
        {

            var result = await _productService.AddAsync(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);



        }
        [HttpPost("delete")]
        public async Task<IActionResult> DeleteAsync(Product product)
        {

            var result = await _productService.DeleteAsync(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public async Task<IActionResult> UpdateAsync(Product product)
        {

            var result = await _productService.UpdateAsync(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("getproductdetail")]
        public async Task<IActionResult> GetProductDetailAsync(){
            var result = await _productService.GetProductDtoAsync();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
    }
}