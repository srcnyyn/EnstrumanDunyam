using Business.Abstract;
using DataAccess.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EDAPI.Controller
{
    [ApiController]
    [Route("[controller]")]

    public class ChildCategoryController : ControllerBase
    {
        IChildCategoryService _childCategoryService;

        public ChildCategoryController(IChildCategoryService childCategoryService)
        {
            _childCategoryService = childCategoryService;
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var result = await _childCategoryService.GetAsync(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _childCategoryService.GetAllAsync();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public async Task<IActionResult> AddAsync(ChildCategory childCategory)
        {
            var result = await _childCategoryService.AddAsync(childCategory);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteAsync(ChildCategory childCategory)
        {
            var result = await _childCategoryService.DeleteAsync(childCategory);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public async Task<IActionResult> UpdateAsync(ChildCategory childCategory)
        {
            var result = await _childCategoryService.UpdateAsync(childCategory);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbycategoryid")]
        public async Task<IActionResult> GetByCategoryIdAsync(int categoryId){
            var result = await _childCategoryService.GetByCategoryIdAsync(categoryId);
             if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}