using Microsoft.AspNetCore.Mvc;
using backend.Services;
using backend.Models;

namespace backend.Controllers;

[Controller]
[Route("[controller]")]

public class UserController : Controller
{

    private readonly UserService _userService;

    public UserController(UserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public async Task<List<User>> Get()
    {
        return await _userService.GetAsync();
    }

    [HttpGet("{id}")]
    public async Task<User> GetbyId(string id)
    {
        return await _userService.GetbyIdAsync(id);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] User user)
    {
        await _userService.CreateAsync(user);
        return CreatedAtAction(nameof(Get), new { id = user.Id }, user);

    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(string id, [FromBody] User user) {
        await _userService.UpdateAsync(id, user);
        return NoContent();
        
    }


    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        await _userService.DeleteAsync(id);
        return NoContent();
    }

}