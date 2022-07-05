using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ViacaoCalango.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrechoController : ControllerBase
    {
        // GET: api/<TrechoController>
        [HttpGet]
        public List<string> Get()
        {
            
            return new List<string>(0);
        }

        // GET api/<TrechoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TrechoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TrechoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TrechoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
