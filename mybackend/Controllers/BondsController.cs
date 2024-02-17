using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


[Route("api/bonds")]
public class BondsController : ControllerBase
{
    private readonly AppDbContext _context;

    public BondsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetBonds()
    {
        try
        {
            var Bonds = await _context.Bonds.ToListAsync();
            return Ok(Bonds);
        }
        catch (Exception ex)
        {
            // Log the exception or handle it appropriately
            return StatusCode(500, "Internal Server Error");
        }
    }
    // Implement other CRUD operations as needed
}
