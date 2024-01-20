using Microsoft.AspNetCore.Mvc;

namespace API;

[ApiController]
[Route("[controller]")]
public class MarioController : ControllerBase // route = domain.tld/Mario ("Mario"Controller without Controller is route)
{
    [HttpGet] // /mario
    public IActionResult Mariov()
    {
        return Ok("Hello World");
    }
    [HttpGet("test")] // /mario/test
    public IActionResult Mariox()
    {
        return Ok("Hello Worldx");
    }
}
