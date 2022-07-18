﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ViacaoCalango.Application.ViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ViacaoCalango.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaController : ControllerBase
    {
        // GET: api/<ReservaController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ReservaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ReservaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ReservaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReservaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet("{consulta}")]
        public IEnumerable<OnibusViewModel> GetQuartosDisponiveis([FromBody] ConsultaRotasViewModel consulta)
        {
            return new List<OnibusViewModel>();
        }
    }
}
