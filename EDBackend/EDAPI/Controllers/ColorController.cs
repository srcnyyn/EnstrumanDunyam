using Business.Abstract;
using DataAccess.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EDAPI.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ColorController : ControllerBase
    {
        IColorService _colorService;

        public ColorController(IColorService colorService)
        {
            _colorService = colorService;
        }
        [HttpGet("getbyid")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {

            var result = await _colorService.GetAsync(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _colorService.GetAllAsync();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("add")]
        public async Task<IActionResult> AddAsync(Color color)
        {
            var result = await _colorService.AddAsync(color);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPut("update")]
        public async Task<IActionResult> UpdateAsync(Color color)
        {

            var result = await _colorService.UpdateAsync(color);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteAsync(Color color)
        {

            var result = await _colorService.DeleteAsync(color);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}