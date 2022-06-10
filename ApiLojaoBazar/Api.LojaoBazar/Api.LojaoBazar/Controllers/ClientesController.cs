using Api.LojaoBazar.Application.AppService;
using Api.LojaoBazar.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.LojaoBazar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {               

        // GET: api/<ClientesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ClientesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            ClienteAppService clienteAppService = new ClienteAppService();
            return clienteAppService.Get(id).ToString();            
        }

        // POST api/<ClientesController>
        [HttpPost]
        public void Post([FromBody] ClienteCreateViewModel clienteCreateViewModel)
        {
            ClienteAppService clienteAppService = new ClienteAppService();
            clienteAppService.Create(clienteCreateViewModel);
          
        }

        // PUT api/<ClientesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClientesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
