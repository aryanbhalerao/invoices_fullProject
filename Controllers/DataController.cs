using Microsoft.AspNetCore.Mvc;

namespace InvoiceApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DataController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetData()
        {
            string result = "Data fetched";
            if(result.Length > 0)
            {
                return Ok(new { message = result });
            }
            return BadRequest("No data");
        }
    }
}