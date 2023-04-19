using Microsoft.AspNetCore.Mvc;
using backend.Services;
using backend.Models;
using Microsoft.AspNetCore.Authorization;

namespace backend.Controllers;

[Authorize]
[Controller]
[Route("api/[controller]")]

public class ChallengeController : Controller
{

    private readonly ChallengeService _challengeService;

    public ChallengeController(ChallengeService challengeService)
    {
        _challengeService = challengeService;
    }

    [Authorize(Roles = "Admin")]
    [HttpGet]
    public async Task<List<Challenge>> Get()
    {
        return await _challengeService.GetAsync();
    }

    [HttpGet("{id}")]
    public async Task<Challenge> GetbyId(string id)
    {
        return await _challengeService.GetbyIdAsync(id);
    }

    [Authorize(Roles = "Company, Admin")]
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Challenge challenge)
    {
        await _challengeService.CreateAsync(challenge);
        return CreatedAtAction(nameof(Get), new { id = challenge.Id }, challenge);
    }

    [Authorize(Roles = "Company, Admin")]
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(string id, [FromBody] Challenge challenge)
    {
        await _challengeService.UpdateAsync(id, challenge);
        return NoContent();

    }


    [Authorize(Roles = "Company, Admin")]
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        await _challengeService.DeleteAsync(id);
        return NoContent();
    }

}