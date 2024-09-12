using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
namespace DAMZ_1192024.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProtetedController : ControllerBase
    {
        static List<object> data = new List<object>();

        [HttpGet]
        public IEnumerable<object>Get(){
            return data;
        }
        [HttpPost]
        public IActionResult Post(string name, string lasteName){
            data.Add(new {name, lasteName});
            return Ok();
        }
    };
}
