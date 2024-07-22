using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiProject.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ReportsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("complex-query")]
        public async Task<IActionResult> GetComplexReport()
        {
            var result = await _context.SampleModels
                .GroupBy(s => s.Name)
                .Select(g => new 
                {
                    Name = g.Key,
                    Count = g.Count(),
                    MaxId = g.Max(s => s.Id),
                    MinId = g.Min(s => s.Id)
                })
                .OrderByDescending(r => r.Count)
                .Take(10)
                .ToListAsync();

            return Ok(result);
        }
    }
}
