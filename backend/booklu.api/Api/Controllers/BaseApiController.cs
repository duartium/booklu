using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace booklu.api.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BaseApiController<T> : ControllerBase where T : BaseApiController<T>
{
    private IMediator _mediator;
    private ILogger<T> _logger;
    public IConfiguration _configuration;

    protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
    protected ILogger<T> Logger => _logger ??= HttpContext.RequestServices.GetService<ILogger<T>>();
    protected IConfiguration Configuration => _configuration ??= HttpContext.RequestServices.GetService<IConfiguration>();
}
