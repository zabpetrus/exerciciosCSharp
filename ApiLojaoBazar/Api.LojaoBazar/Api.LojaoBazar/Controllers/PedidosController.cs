using Api.LojaoBazar.Application.AppService;
using Api.LojaoBazar.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.LojaoBazar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        // GET: api/<PedidosController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PedidosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            //Retorna um pedido especifico
            PedidoAppService pedidoAppService = new PedidoAppService();
            PedidoResultViewModel pedidoResultViewModel  = pedidoAppService.GetById(id);
           return pedidoResultViewModel.ToString();
        }

        // POST api/<PedidosController>
        [HttpPost]
        public void Post([FromBody] PedidoCreateViewModel pedidoCreateViewModel)
        {
            //Criação de um novo pedido
            PedidoAppService pedidoAppService = new PedidoAppService();
            pedidoAppService.Create(pedidoCreateViewModel);           
        }

        // PUT api/<PedidosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PedidosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
