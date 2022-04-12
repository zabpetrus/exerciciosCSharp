using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalculaFreteApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

 // Era ControllerBase, mas pra inserir uma View precisei mudar a classe base
 // E também é necessário registrar o uso de Views/Controllers  no arquivo Startup.cs
    public class FreteController : Controller
    {
        // GET: api/<FreteController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
                
     
        // GET api/<FreteController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FreteController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FreteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FreteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return View("~/Pages/Index.cshtml");
        }
    }
}
