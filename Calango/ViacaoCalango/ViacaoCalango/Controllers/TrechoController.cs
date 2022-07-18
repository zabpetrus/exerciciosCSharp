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
    public class TrechoController : ControllerBase
    {
        // GET: api/<TrechoController>
        [HttpGet]
        public List<string> Get()
        {
            TrechoAppService trechoAppService = new TrechoAppService();
            var listaTrechos = trechoAppService.GetAll();
            return listaTrechos.Select(s => s.toString()).ToList();
            
        }

        // GET api/<TrechoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            TrechoAppService trechoAppService = new TrechoAppService();
            return trechoAppService.GetById(id).ToString();
        }

        // POST api/<TrechoController>
        [HttpPost]
        public void Post([FromBody] TrechoViewModel value)
        {
            TrechoAppService trechoAppService = new TrechoAppService();
            if( trechoAppService.CreateTrecho(value))
            {
                StatusCode(201);
            }
        }

        // PUT api/<TrechoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] TrechoViewModel value)
        {
            TrechoAppService trechoAppService = new TrechoAppService();
            if(trechoAppService.UpdateTrecho(id, value))
            {
                StatusCode(202);
            }
        }

        // DELETE api/<TrechoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            TrechoAppService trechoAppService = new TrechoAppService();
            if(trechoAppService.DeleteTrecho(id))
            {
                StatusCode(203);
            }
        }
    }
}
