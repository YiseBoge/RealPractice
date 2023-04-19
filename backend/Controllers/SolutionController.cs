using Microsoft.AspNetCore.Mvc;
using backend.Services;
using backend.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace backend.Controllers;

[Authorize]
[Controller]
[Route("api/[controller]")]


public class SolutionController : Controller
{

    private readonly SolutionService _solutionService;

    public SolutionController(SolutionService solutionService)
    {
        _solutionService = solutionService;
    }


    [HttpGet]
    public async Task<ActionResult<List<Solution>>> Get()
    {

        if (User.IsInRole("Admin") || User.IsInRole("teacher") || User.IsInRole("Company"))
        {
            return await _solutionService.GetAsync();
        }

        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        if (userId == null)
        {
            return Unauthorized();
        }

        return await _solutionService.GetbySolverIdAsync(userId);

    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Solution>> GetbyId(string id)
    {
        var solution = await _solutionService.GetbyIdAsync(id);

        if (solution == null)
        {
            return NotFound();
        }

        if (User.IsInRole("Admin") || User.IsInRole("teacher") || User.IsInRole("Company"))
        {
            return solution;
        }

        if (solution.SolverStudent == User.FindFirst(ClaimTypes.NameIdentifier)?.Value)
        {
            return solution;
        }


        return Forbid();
    }

    [AllowAnonymous]
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Solution solution)
    {
        await _solutionService.CreateAsync(solution);
        return CreatedAtAction(nameof(Get), new { id = solution.Id }, solution);
    }

    [Authorize(Roles = "Company, Admin")]
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(string id, [FromBody] Solution solution)
    {
        await _solutionService.UpdateAsync(id, solution);
        return NoContent();

    }


    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        var solution = await _solutionService.GetbyIdAsync(id);

        if (solution == null)
        {
            return NotFound();
        }

        if (User.IsInRole("Admin") || User.IsInRole("teacher") || User.IsInRole("Company"))
        {
            await _solutionService.DeleteAsync(id);
            return NoContent();
        }

        if (solution.SolverStudent == User.FindFirst(ClaimTypes.NameIdentifier)?.Value)
        {
            await _solutionService.DeleteAsync(id);
            return NoContent();
        }

        return Forbid();
    }

}