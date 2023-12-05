using Microsoft.AspNetCore.Mvc;
using ProductAPI.Entities;
using ProductAPI.Responses;
using ProductAPI.Services;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CategoryService _service;

        public CategoryController(CategoryService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> FindById(int id)
        {
            try
            {
                var result = await _service.GetById(id);
                if (result is ResponseError)
                {
                    return NotFound(result);

                }
                return Ok(result);
            }
            catch
            {
                return BadRequest();
            }

        }
    }
}
