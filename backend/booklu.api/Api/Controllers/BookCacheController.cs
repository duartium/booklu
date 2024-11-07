using booklu.api.Application.Cache.RecentlyViewedBooksCache;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace booklu.api.Api.Controllers;

[Route("api/books-cache")]
[ApiController]
public class BookCacheController : BaseApiController<BookCacheController>
{
    private readonly CacheBooks<string> _booksCache;
    private readonly IHttpContextAccessor _httpContextAccessor;
    public BookCacheController(CacheBooks<string> cacheBooks, 
        IHttpContextAccessor httpContextAccessor)
    {
        _booksCache = cacheBooks;
        _httpContextAccessor = httpContextAccessor;
    }

    /// <summary>
    /// get a list of recently viewed books cache for show at the client applications
    /// </summary>
    /// <returns></returns>
    [HttpGet("recently-viewed")]
    public  IActionResult GetRecentlyViewedBooksCacheAsync()
    {
        //var cacheBooks = _booksCache.GetAllElementsAsJson();

        var session = _httpContextAccessor.HttpContext.Session; 
        var jsonCache = session.GetString("BookCache"); 
        
        if (jsonCache is null) 
            return Ok("[]");
        
        var cacheBooks = JsonSerializer.Deserialize<CacheBooks<string>>(jsonCache);
        return Ok(cacheBooks.GetAllElementsAsJson());
    }

    /// <summary>
    /// add element to list of recently viewed books cache for show at the client applications
    /// </summary>
    /// <returns></returns>
    [HttpPost("add-recently-viewed")]
    public IActionResult AddToRecentlyViewedBooksCacheAsync([FromBody] string bookTitle)
    {
        var session = _httpContextAccessor.HttpContext.Session;
        var jsonCacheBooks = session.GetString("BookCache");

        CacheBooks<string> cacheBooks; 
        if (jsonCacheBooks != null)
            cacheBooks = JsonSerializer.Deserialize<CacheBooks<string>>(jsonCacheBooks); 
        else
            cacheBooks = new CacheBooks<string>();

        cacheBooks.AddBook(bookTitle);
        var x = JsonSerializer.Serialize(cacheBooks, new JsonSerializerOptions { WriteIndented = true })
        session.SetString("BookCache", JsonSerializer.Serialize(cacheBooks, new JsonSerializerOptions { WriteIndented = true }));

        var jsonCacheBooks1 = session.GetString("BookCache");
        var cacheBooks1 = JsonSerializer.Deserialize<CacheBooks<string>>(jsonCacheBooks);

        return Created();
    }
}
