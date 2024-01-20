using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
public class RootController : ControllerBase
{
    [HttpGet("Helloworld")]
    public IActionResult Helloworld()
    {
        return Ok("Hello World");
    }
}
