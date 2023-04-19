using Microsoft.AspNetCore.Mvc;
using backend.Services;
using backend.Models;
using Microsoft.AspNetCore.Authorization;

namespace backend.Controllers;

[Authorize(Roles = "Company, Admin")]
[Controller]
[Route("api/[controller]")]


public class CompanyController : Controller
{

    private readonly CompanyService _companyService;

    public CompanyController(CompanyService companyService)
    {
        _companyService = companyService;
    }


    [HttpGet]
    public async Task<List<Company>> Get()
    {
        return await _companyService.GetAsync();
    }

    [HttpGet("{id}")]
    public async Task<Company> GetbyId(string id)
    {
        return await _companyService.GetbyIdAsync(id);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Company company)
    {
        await _companyService.CreateAsync(company);
        return CreatedAtAction(nameof(Get), new { id = company.Id }, company);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(string id, [FromBody] Company company) {
        await _companyService.UpdateAsync(id, company);
        return NoContent();
        
    }


    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        await _companyService.DeleteAsync(id);
        return NoContent();
    }

}