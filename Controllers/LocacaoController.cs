using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste_Programacao_Wipro.Model;
using Teste_Programacao_Wipro.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Teste_Programacao_Wipro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocacaoController : ControllerBase
    {
        private readonly ILocacaoService LocacaoService;

        public LocacaoController() 
        {
            LocacaoService = new LocacaoService();
        }

        // GET: api/<LocacaoController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(LocacaoService.GetLocacao());
        }

        // GET api/<LocacaoController>/5
        [HttpGet("{idLocacao}")]
        public IActionResult GetLocacao(string IdLocacao)
        {
            return Ok(LocacaoService.Getlocacao(IdLocacao));
        }

        // POST api/<LocacaoController>
        [HttpPost]
        public IActionResult Post([FromBody] Locacao entity)
        {
            LocacaoService.Add(entity);
            return Ok();
        }

        // PUT api/<LocacaoController>/Devolução
        [HttpPut]
        [Route("/Devolucao")]
        public IActionResult Devolução([FromBody] Locacao entity)
        {  
            return Ok(LocacaoService.DevolverFilme(entity));
        }

        // DELETE api/<LocacaoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
