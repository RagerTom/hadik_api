using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace hadik_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HadikPartsController : ControllerBase
    {
        private readonly DataContext _context;

        public HadikPartsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<ActionResult<List<HadikParts>>> GetHadikParta()
        {

            return Ok(await _context.HadikSavedParts.ToListAsync());
        }

        [HttpDelete]

        public async Task<ActionResult<List<HadikParts>>> DeleteHadikParts()
        {
            var rows = from o in _context.HadikSavedParts
                       select o;
            foreach (var row in rows)
            {
                _context.HadikSavedParts.Remove(row);
            }
            await _context.SaveChangesAsync();


            return Ok(await _context.HadikSavedParts.ToListAsync());
        }

        [HttpPost]

        public async Task<ActionResult<List<HadikParts>>> addHadikParts(HadikParts request)
        {
            _context.HadikSavedParts.Add(request);
            await _context.SaveChangesAsync();

            return Ok(await _context.HadikSavedParts.ToListAsync());
        }
    }
}
