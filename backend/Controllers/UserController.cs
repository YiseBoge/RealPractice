using Microsoft.AspNetCore.Mvc;
using backend.Services;
using backend.Models;

namespace backend.Controllers;

[Controller]
[Route("[controller]")]

public class UserController : Controller
{

    private readonly MongoDBService _mongoDBService;

    public UserController(MongoDBService mongoDBService)
    {
        _mongoDBService = mongoDBService;
    }

    [HttpGet]
    public async Task<List<User>> Get()
    {
        return await _mongoDBService.GetAsync();
    }

    [HttpGet("{id}")]
    public async Task<User> GetbyId(string id)
    {
        return await _mongoDBService.GetbyIdAsync(id);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] User user)
    {
        await _mongoDBService.CreateAsync(user);
        return CreatedAtAction(nameof(Get), new { id = user.Id }, user);
    }


    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        await _mongoDBService.DeleteAsync(id);
        return NoContent();
    }

}