using System;
using System.Collections.Generic;
using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace EDAPI.Controller
{
    [ApiController]
    [Route("[controller]")]

    public class ChildCategoryController:ControllerBase
    {
         IChildCategoryService _childCategoryService;

        public ChildCategoryController(IChildCategoryService childCategoryService)
        {
            _childCategoryService = childCategoryService;
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            ChildCategory childCategory = new();
            try
            {
                childCategory = _childCategoryService.Get(id);
            }

            catch(Exception ex)
            {
                return BadRequest(ex);
            }
            return Ok(childCategory);

        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            List<ChildCategory> childCategories = new();
            try
            {
                childCategories = _childCategoryService.GetAll();
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
            return Ok(childCategories);
        }
        [HttpPost("add")]
        public IActionResult Add(ChildCategory childCategory)
        {
            try
            {
                _childCategoryService.Add(childCategory);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
            return Ok();
        }
        [HttpDelete("delete")]
        public IActionResult Delete(ChildCategory childCategory)
        {
            try
            {
                _childCategoryService.Delete(childCategory);
            }
            catch (Exception ex)
            {
                
                return BadRequest(ex);
            }
            return Ok();
        }
        [HttpPut("update")]
        public IActionResult Update(ChildCategory childCategory)
        {
            try
            {
                _childCategoryService.Update(childCategory);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);                
            }
            return Ok();
        }
    }
    
}