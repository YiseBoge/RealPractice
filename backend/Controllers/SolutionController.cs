using Microsoft.AspNetCore.Mvc;
using backend.Services;
using backend.Models;

namespace backend.Controllers;

[Controller]
[Route("[controller]")]


public class SolutionController : Controller
{

    private readonly SolutionService _solutionService;

    public SolutionController(SolutionService solutionService)
    {
        _solutionService = solutionService;
    }

    [HttpGet]
    public async Task<List<Solution>> Get()
    {
        return await _solutionService.GetAsync();
    }

    [HttpGet("{id}")]
    public async Task<Solution> GetbyId(string id)
    {
        return await _solutionService.GetbyIdAsync(id);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Solution solution)
    {
        await _solutionService.CreateAsync(solution);
        return CreatedAtAction(nameof(Get), new { id = solution.Id }, solution);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(string id, [FromBody] Solution solution) {
        await _solutionService.UpdateAsync(id, solution);
        return NoContent();
        
    }


    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        await _solutionService.DeleteAsync(id);
        return NoContent();
    }

}