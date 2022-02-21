using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace hadik_api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class HadikController : ControllerBase
    {

       
        private readonly DataContext _context;

        public HadikController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
     
        public async Task<ActionResult<List<Hadik>>> GetHadikData()
        {

            return Ok(await _context.HadikSavedData.ToListAsync());
        }

        [HttpDelete]
      
        public async Task<ActionResult<List<Hadik>>> DeleteHadikData()
        {
            var rows = from o in _context.HadikSavedData
                       select o;
            foreach (var row in rows)
            {
                _context.HadikSavedData.Remove(row);
            }
            await _context.SaveChangesAsync();

            return Ok(await _context.HadikSavedData.ToListAsync());
        }

        [HttpPost]

        public async Task<ActionResult<List<Hadik>>> addHadikData(Hadik request)
        {


            _context.HadikSavedData.Add(request);
            await _context.SaveChangesAsync();

            return Ok(await _context.HadikSavedData.ToListAsync());
        }
    }
}