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
    public class RotaController : ControllerBase
    {
        // GET: api/<RotaController>
        [HttpGet]
        public List<string> Get()
        {
            RotaAppService rotaAppService = new RotaAppService();
            var listaRotas = rotaAppService.GetAllRoutes();
            return listaRotas.Select(s => s.toString()).ToList();
            
        }

        // GET api/<RotaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            RotaAppService rotaAppService = new RotaAppService();
            return rotaAppService.GetRouteById(id).ToString();
        }

        // POST api/<RotaController>
        [HttpPost]
        public void Post([FromBody] RotaViewModel route)
        {
            RotaAppService rotaAppService = new RotaAppService();
            bool result = rotaAppService.CreateRoute(route);
            if (result)
            {
                StatusCode(203);
            }
        }

        // PUT api/<RotaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] RotaViewModel value)
        {
            RotaAppService rotaAppService = new RotaAppService();
            var result = rotaAppService.UpdateRoute(id, value);
            if(result)
            {
                StatusCode(204);
            }
        }

        // DELETE api/<RotaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            RotaAppService rotaAppService=new RotaAppService();
            var result = rotaAppService.DeleteRoute(id);
            if(result)
            {
                StatusCode(203);
            }
        }
    }
}
