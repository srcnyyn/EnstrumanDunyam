using System;
using System.Collections.Generic;
using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace EDAPI.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController:ControllerBase
    {
        ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            Category result = new Category();
            try
            {
             result = _categoryService.Get(id);   
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
            return Ok(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            List<Category> result = new();
            try
            {
                result = _categoryService.GetAll();
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
            return Ok(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Category category)
        {
            try
            {
                _categoryService.Add(category);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
            return Ok();
        }
        [HttpDelete("delete")]
        public IActionResult Delete(Category category)
        {
            try
            {
            _categoryService.Delete(category);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
            return Ok();
        }
        [HttpPut("update")]
        public IActionResult Update(Category category)
        {
            try
            {
                _categoryService.Update(category);

            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
            return Ok();
        }

    }
}