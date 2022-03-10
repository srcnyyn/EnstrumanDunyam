using System;
using System.Collections.Generic;
using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult GetById(int id)
        {
            var result = _childCategoryService.Get(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _childCategoryService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(ChildCategory childCategory)
        {
            var result = _childCategoryService.Add(childCategory);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(ChildCategory childCategory)
        {
            var result = _childCategoryService.Delete(childCategory);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Update(ChildCategory childCategory)
        {
            var result = _childCategoryService.Update(childCategory);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}