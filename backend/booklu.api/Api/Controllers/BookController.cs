using Microsoft.AspNetCore.Mvc;

namespace booklu.api.Api.Controllers;

[Route("api/book")]
[ApiController]
public class BookController : BaseApiController<BookController>
{

    [HttpPost("create")]
    public IActionResult Create()
    {
        return Ok();
    }

}
