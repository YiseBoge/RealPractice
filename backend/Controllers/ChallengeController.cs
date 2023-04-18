using Microsoft.AspNetCore.Mvc;
using backend.Services;
using backend.Models;

namespace backend.Controllers;

[Controller]
[Route("[controller]")]

public class ChallengeController : Controller
{

    private readonly ChallengeService _challengeService;

    public ChallengeController(ChallengeService challengeService) 
    {
        _challengeService = challengeService;  }

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

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Challenge challenge)
    {
        await _challengeService.CreateAsync(challenge);
        return CreatedAtAction(nameof(Get), new { id = challenge.Id }, challenge);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(string id, [FromBody] Challenge challenge) {
        await _challengeService.UpdateAsync(id, challenge);
        return NoContent();
        
    }


    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        await _challengeService.DeleteAsync(id);
        return NoContent();
    }

}