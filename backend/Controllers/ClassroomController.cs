using Microsoft.AspNetCore.Mvc;
using backend.Services;
using backend.Models;

namespace backend.Controllers;

[Controller]
[Route("[controller]")]

public class ClassroomController : Controller
{

    private readonly ClassroomService _classroomService;

    public ClassroomController(ClassroomService classroomService)
    {
        _classroomService = classroomService;
    }

    [HttpGet]
    public async Task<List<Classroom>> Get()
    {
        return await _classroomService.GetAsync();
    }

    [HttpGet("{id}")]
    public async Task<Classroom> GetbyId(string id)
    {
        return await _classroomService.GetbyIdAsync(id);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Classroom classroom)
    {
        await _classroomService.CreateAsync(classroom);
        return CreatedAtAction(nameof(Get), new { id = classroom.Id }, classroom);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(string id, [FromBody] Classroom classroom) {
        await _classroomService.UpdateAsync(id, classroom);
        return NoContent();
        
    }


    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        await _classroomService.DeleteAsync(id);
        return NoContent();
    }

}