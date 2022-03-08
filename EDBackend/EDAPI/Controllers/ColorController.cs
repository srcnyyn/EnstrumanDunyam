using System;
using System.Collections.Generic;
using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace EDAPI.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class ColorController : ControllerBase
    {
        IColorService _colorService;

        public ColorController(IColorService colorService)
        {
            _colorService = colorService;
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            Color result = new Color();
            try
            {
                result = _colorService.Get(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            return Ok(result);

        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            List<Color> result = new List<Color>();
            try
            {
                result = _colorService.GetAll();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            return Ok(result);

        }
        [HttpPost("add")]
        public IActionResult Add(Color color)
        {
            try
            {
                _colorService.Add(color);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            return Ok();
        }
        [HttpPut("update")]
        public IActionResult Update(Color color)
        {
            try
            {
                _colorService.Update(color);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            return Ok();
        }
        [HttpDelete("delete")]
        public IActionResult Delete(Color color)
        {
            try
            {
                _colorService.Delete(color);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
            return Ok();
        }
    }
}