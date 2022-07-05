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
    public class ReservaController : ControllerBase
    {
        // GET: api/<ReservaController>
        [HttpGet]
        public List<string> Get()
        {
            ReservaAppService reservaAppService = new ReservaAppService();
            var listaReservas = reservaAppService.GetAll();
            return listaReservas.Select(s => s.toString()).ToList();
        }

        // GET api/<ReservaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            ReservaAppService reservaAppService = new ReservaAppService();
            return reservaAppService.GetById(id).toString();
        }

        // POST api/<ReservaController>
        [HttpPost]
        public void Post([FromBody] ReservaViewModel reservaViewModel)
        {
            ReservaAppService reservaAppService = new ReservaAppService();
            if(reservaAppService.Create(reservaViewModel))
            {
                StatusCode(201);
            }
        }

        // PUT api/<ReservaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ReservaViewModel reservaViewModel)
        {
            ReservaAppService reservaAppService = new ReservaAppService();
            if(reservaAppService.Update(id, reservaViewModel))
            {
                StatusCode(202);
            }
        }

        // DELETE api/<ReservaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ReservaAppService reservaAppService = new ReservaAppService();
            if(reservaAppService.Delete(id))
            {
                StatusCode(203);
            }
        }
    }
}
