using Microsoft.AspNetCore.Mvc;
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
            catch (Exception e)
            {
                return StatusCode(500, new { message = "internal server error", error = e.Message });
            }

        }
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> FindAll()
        {
            try
            {
                var result = await _service.GetAll();
                if (result is ResponseError)
                {
                    return NotFound(result);

                }
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode(500, new { message = "internal server error", error = e.Message });
            }

        }
    }
}
