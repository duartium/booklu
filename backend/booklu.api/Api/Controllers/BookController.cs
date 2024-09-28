using Microsoft.AspNetCore.Mvc;

namespace booklu.api.Api.Controllers;

[Route("api/book")]
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
