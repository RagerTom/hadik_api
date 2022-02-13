using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace hadik_api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class HadikController : ControllerBase
    {

        private static List<Hadik> hadikData = new List<Hadik>
        {
           
        };
        [HttpGet]
        [Route("GetHadikData")]
        public async Task<ActionResult<List<Hadik>>> GetHadikData()
        {


            return Ok(hadikData);
        }

        [HttpPost]
        [Route("PostHadikData")]
        public async Task<ActionResult<List<Hadik>>> AddhadikData(Hadik api)
        {

            hadikData.Insert(0, api);
            return Ok(hadikData);
        }
    }   
}
