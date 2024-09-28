using booklu.api.Core.Application.Builders;
using booklu.api.Core.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace booklu.api.Api.Controllers;

[Route("api/employee")]
[ApiController]
public class EmployeeController : BaseApiController<EmployeeController>
{
    public EmployeeController()
    {

    }

    [HttpPost("create")]
    public IActionResult Create()
    {
        Employee employee = new EmployeeBuilder()
            .setName("Duartium")
            .setAddress(new Address { City = "Santiago", Country = "Chile", StreetMain = "Plaza de las armas" })
            .setContact(new Contact { Email = "example@live.com", Phone = "000000000" })
            .setAge(99)
            .Build();

        return Ok(employee);
    }
}
