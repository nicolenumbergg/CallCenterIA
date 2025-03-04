using BaseLibrary.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServerLibrary.Repositories.Contracts;

namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthenticationController(IUserAccount accountInterface) : ControllerBase
{
    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] Register? user)
    {
        if (user is null) return BadRequest("El modelo esta vacio");
        
        var result = await accountInterface.CreateAsync(user);
        return Ok(result);
    }
    
    [AllowAnonymous]
    [HttpPost("login")]
    public async Task<IActionResult> SignInAsync(Login? user)
    {
        if (user is null) return BadRequest("El modelo esta vacio");
        
        var result = await accountInterface.SignInAsync(user);
        return Ok(result);
    }
    
    [AllowAnonymous]
    [HttpPost("refresh")]
    public async Task<IActionResult> RefreshToken([FromBody] RefreshToken? token)
    {
        if (token is null) return BadRequest("El modelo esta vacio");
        
        var result = await accountInterface.RefreshTokenAsync(token);
        return Ok(result);
    }
}