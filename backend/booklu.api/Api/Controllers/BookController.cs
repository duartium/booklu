using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace booklu.api.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : BaseApiController<BookController>
    {
        public BookController()
        {

        }

        [HttpPost("create")]
        public IActionResult Create()
        {
            

            return Ok();
        }

    }
}
