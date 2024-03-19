using Microsoft.AspNetCore.Mvc;
using mugt_back.Dtos;
using mugt_back.Services;

namespace mugt_back.Controllers;

[ApiController]
[Route("[controller]")]
public class GenerateUserController : ControllerBase
{
    [HttpPost]
    public IActionResult GenerateUser([FromBody] GenerateUserRequestDto bodyObject)
    {
        if (bodyObject == null)
        {
            return BadRequest();
        }

        GenerateUserResponseDto responseObject = GenerateService.Start(bodyObject);
        return Ok(responseObject);
    }
}
