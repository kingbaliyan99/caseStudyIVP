using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


[Route("api/equities")]
public class EquitiesController : ControllerBase
{
    private readonly AppDbContext _context;

    public EquitiesController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetEquities()
    {
        try
        {
            var equities = await _context.Equities.ToListAsync();
            return Ok(equities);
        }
        catch (Exception ex)
        {
            // Log the exception or handle it appropriately
            return StatusCode(500, "Internal Server Error");
        }
    }
    // Implement other CRUD operations as needed
}
