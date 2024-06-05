using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendDemo1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        public TestController()
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        [Route("Test")]
        public IActionResult TestMessage()
        {
            try
            {
                Dictionary<string, string> dicRes = 
                    new Dictionary<string, string>();
                dicRes.Add("Mensaje", "Hola Mundo desde mi API");

                return StatusCode(200, dicRes);
            }
            catch (Exception err)
            {
                return StatusCode(500, err.Message);
            }
        }
    }


}
