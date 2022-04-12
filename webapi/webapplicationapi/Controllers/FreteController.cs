using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webapplicationapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FreteController : ControllerBase
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

        /*********************************************
         * Apenas para teste. A api para calculo do frete
         * requer outros valores,além de autenticação
         * Ainda não achei         * 
         * ******************************************/
        [HttpGet("{cep}/{peso}")]
        public double ObtemValor(int cep, double peso)
        {           
           
            Frete frete = new Frete(null);
            frete.cep = 25896210;
            frete.peso = 4.5;
            double fretevalor = frete.CalculaFrete();
            return fretevalor;
        }
    }
}
