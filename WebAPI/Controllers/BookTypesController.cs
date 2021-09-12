using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookTypesController : ControllerBase
    {
        IBookTypeService _booktypeService;

        public BookTypesController(IBookTypeService booktypeService)
        {
            _booktypeService = booktypeService;
        }

        [HttpGet("getall")]

        public IActionResult GetAll()
        {
            var result = _booktypeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]

        public IActionResult ADd(BookType  bookType)
        {
            var result = _booktypeService.Add(bookType);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("delete")]

        public IActionResult Delete(BookType bookType)
        {
            var result = _booktypeService.Delete(bookType);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
