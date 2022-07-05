using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ViacaoCalango.Application.AppService;
using ViacaoCalango.Application.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ViacaoCalango.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassageiroController : ControllerBase
    {
        // GET: api/<PassageiroController>
        [HttpGet]
        public List<string> Get()
        {
            PassageiroAppService passageiroAppService = new PassageiroAppService();
            var listadePassageiros = passageiroAppService.GetAll();
            return listadePassageiros.Select(s => s.toString()).ToList();
        }

        // GET api/<PassageiroController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            PassageiroAppService passageiroAppService=new PassageiroAppService();
            return passageiroAppService.GetById(id).toString();
        }

        // POST api/<PassageiroController>
        [HttpPost]
        public void Post([FromBody] PassageiroViewModel passageiro)
        {
            PassageiroAppService passageiroAppService = new PassageiroAppService();
            if (passageiroAppService.Create(passageiro))
            {
                StatusCode(201);
            }
        }

        // PUT api/<PassageiroController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] PassageiroViewModel passageiro)
        {
            PassageiroAppService passageiroAppService = new PassageiroAppService();
            if(passageiroAppService.Update(id,passageiro))
            {
                StatusCode(201);
            }
        }

        // DELETE api/<PassageiroController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            PassageiroAppService passageiroAppService = new PassageiroAppService();
            if(passageiroAppService.Delete(id))
            {
                StatusCode(201);
            }
        }
    }
}
