using Microsoft.AspNetCore.Mvc;
using backend.Services;
using backend.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace backend.Controllers;

[Controller]
[Authorize]
[Route("api/[controller]")]

public class UserController : Controller
{

    private readonly UserService _userService;

    public UserController(UserService userService)
    {
        _userService = userService;
    }

    [Authorize(Roles = "Admin")]
    [HttpGet]
    public async Task<List<User>> Get()
    {
        return await _userService.GetAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetbyId(string id)
    {

        if (User.FindFirst(ClaimTypes.NameIdentifier)?.Value != null)
        {
            // Get the user ID from the claim
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            // Check if the user is authorized to access the resource
            if (userId == id || User.IsInRole("Admin"))
            {
                // Return the resource
                return await _userService.GetbyIdAsync(id);
            }
            else
            {
                // Return a 403 Forbidden response
                return Forbid();
            }
        }
        else
        {
            // Return a 401 Unauthorized response
            return Unauthorized();
        }
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] User user)
    {
        await _userService.CreateAsync(user);
        return CreatedAtAction(nameof(Get), new { id = user.Id }, user);

    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(string id, [FromBody] User user)
    {
        if (User.FindFirst(ClaimTypes.NameIdentifier)?.Value != null)
        {
            // Get the user ID from the claim
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            // Check if the user is authorized to access the resource
            if (userId == id || User.IsInRole("Admin"))
            {
                // Return the resource
                await _userService.UpdateAsync(id, user);
                return NoContent();
            }
            else
            {
                // Return a 403 Forbidden response
                return Forbid();
            }
        }
        else
        {
            // Return a 401 Unauthorized response
            return Unauthorized();
        }

    }


    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        if (User.FindFirst(ClaimTypes.NameIdentifier)?.Value != null)
        {
            // Get the user ID from the claim
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            // Check if the user is authorized to access the resource
            if (userId == id || User.IsInRole("Admin"))
            {

                await _userService.DeleteAsync(id);
                return NoContent();
            }
            else
            {
                // Return a 403 Forbidden response
                return Forbid();
            }
        }
        else
        {
            // Return a 401 Unauthorized response
            return Unauthorized();
        }

    }

}