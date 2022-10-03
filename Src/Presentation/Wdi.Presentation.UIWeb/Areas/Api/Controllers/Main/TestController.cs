using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Wdi.Presentation.UIWeb.Areas.Api.Controllers.Main
{
    [Route("api")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        [Route("connection-test")]
        public IActionResult ConnectionTest()
        {
            return Ok("Bağlantı Sağlandı");
        }
    }
}
