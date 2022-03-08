using System;
using System.Collections.Generic;
using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace EDAPI.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class BrandController : ControllerBase
    {
        IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            Brand result = new Brand();
            try
            {
                result = _brandService.Get(id);
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
            List<Brand> result = new List<Brand>();
            try
            {
                result = _brandService.GetAll();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            return Ok(result);

        }
        [HttpPost("add")]
        public IActionResult Add(Brand brand)
        {
            try
            {
                _brandService.Add(brand);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            return Ok();
        }
        [HttpPut("update")]
        public IActionResult Update(Brand brand)
        {
            try
            {
                _brandService.Update(brand);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            return Ok();
        }
        [HttpDelete("delete")]
        public IActionResult Delete(Brand brand)
        {
            try
            {
                _brandService.Delete(brand);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
            return Ok();
        }
    }
}