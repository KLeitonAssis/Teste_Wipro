using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste_Programacao_Wipro.Model;
using Teste_Programacao_Wipro.Service;


namespace Teste_Programacao_Wipro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmesController : ControllerBase
    {
        private readonly IFilmeService FilmeService;
        public FilmesController()
        {
            FilmeService = new FilmeService();
        }

        // GET: api/<Cliente>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(FilmeService.GetFilme());
        }

        // GET api/<filme>/5
        [HttpGet("{Titulo}")]
        public IActionResult GetFilme(string Titulo)
        {
            return Ok(FilmeService.GetFilme(Titulo));
        }

        // POST api/<filme>
        [HttpPost]
        public IActionResult Post([FromBody] Filme entity)
        {
            FilmeService.Add(entity);
            return Ok();
        }

        // DELETE api/<filme
        [HttpDelete]
        public IActionResult Delete(string Titulo)
        {
            return Ok(FilmeService.Desativacao(Titulo));
        }
    }
}
