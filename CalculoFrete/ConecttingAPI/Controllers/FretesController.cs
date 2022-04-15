using ConecttingAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


/**********************************************************************
 * 
 * Controlador criado para testar a entrada dos dados e o funcionamento
 * da api * 
 * A classe de serviço é a ConnectCorreiosService.cs
 * 
 * ********************************************************************/


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ConecttingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FretesController : ControllerBase
    {
        //O metodo Get é Sobrecarregado, mas não errado porque o numero de argumentos é diferente
        //No swagger, teremos um campo input para cada propriedade!!!

        [HttpGet("{tipoEnvio}/{cepOrigem}/{cepDestino}/{peso}/{codigoFormatoInt}/{comprimentoDecimal}/{alturaDecimal}/{larguraDecimal}/{diametroDecimal}/{maoPropria}/{valorDeclaradoDecimal}/{avisoRecebimento}")]
        public double Get(
            string tipoEnvio,
            string cepOrigem,
            string cepDestino,
            string peso,
            int codigoFormatoInt,
            decimal comprimentoDecimal,
            decimal alturaDecimal,
            decimal larguraDecimal,
            decimal diametroDecimal,
            string maoPropria,
            decimal valorDeclaradoDecimal,
            string avisoRecebimento
            
        ){
           
            Frete frete = new Frete();
            frete.nCdEmpresa = string.Empty;  // Podemos colocar o valor em branco
            frete.sDsSenha = string.Empty;   // Podemos colocar o valor em branco
            frete.tipoEnvio = tipoEnvio;
            frete.cepOrigem = cepOrigem;
            frete.cepDestino = cepDestino;
            frete.peso = peso;
            frete.codigoFormatoInt = codigoFormatoInt;
            frete.comprimentoDecimal = comprimentoDecimal;
            frete.alturaDecimal = alturaDecimal;
            frete.larguraDecimal = larguraDecimal;
            frete.diametroDecimal = diametroDecimal;
            frete.maoPropria = maoPropria;
            frete.valorDeclaradoDecimal = valorDeclaradoDecimal;
            frete.avisoRecebimento = avisoRecebimento;

            //A api retorna um tipo do tipo cResponse, então devemos fazer o casting para double
            // diretamente no método calculaFrete();
            return frete.CalculaFrete();
        }



        // GET: api/<FretesController> - Não será usada
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<FretesController>/5 - Não será usada
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FretesController> - Não será usada
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FretesController>/5 - Não será usada
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FretesController>/5 - Não será usada
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
