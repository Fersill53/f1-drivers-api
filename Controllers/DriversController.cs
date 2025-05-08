using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using F1DriversApi.Data;
using F1DriversApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace F1DriversApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DriversController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DriversController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Driver>>> GetAll(
            [FromQuery] string? name,
            [FromQuery] string? team,
            [FromQuery] string? sortBy)
        {
            var result = _context.Drivers.AsQueryable();

            if (!string.IsNullOrEmpty(name))
                result = result.Where(d => d.Name.ToLower().Contains(name.ToLower()));

            if (!string.IsNullOrEmpty(team))
                result = result.Where(d => d.Team.ToLower().Contains(team.ToLower()));

            if (!string.IsNullOrEmpty(sortBy))
            {
                switch (sortBy.ToLower())
                {
                    case "points":
                        result = result.OrderByDescending(d => d.Points);
                        break;
                    case "name":
                        result = result.OrderBy(d => d.Name);
                        break;
                    case "carnumber":
                        result = result.OrderBy(d => d.CarNumber);
                        break;
                }
            }

            return await result.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Driver>> GetIdBy(int id)
        {
            var driver = await _context.Drivers.FindAsync(id);
            if (driver == null) return NotFound();
            return Ok(driver);
        }
    }
}
