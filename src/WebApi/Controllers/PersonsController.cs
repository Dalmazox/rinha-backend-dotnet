using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("/pessoas")]
public class PersonsController : ControllerBase
{
    [HttpPost] 
    public IActionResult CreateAsync()
    {
        return Created("", null);
    }

    [HttpGet("{id:guid:required}")]
    public IActionResult FindByIdAsync(Guid id)
    {
        return Ok();
    }

    [HttpGet("{t:required}")]
    public IActionResult FindByTerm(string t)
    {
        return Ok();
    }

    [HttpGet("contagem-pessoas")]
    public IActionResult Count()
    {
        return Ok();
    }
    
}