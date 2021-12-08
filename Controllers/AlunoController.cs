using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SmarthSchool.API.Models;

namespace SmarthSchool.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class AlunoController : ControllerBase
    {
        public List <Aluno> Alunos = new List<Aluno>(){
            new Aluno(){
                Id = 1,
                Nome = "Willian",
                Sobrenome = "Trindade",
                Telefone = "(65)9999-99999"
            },
            new Aluno(){
                 Id = 2,
                Nome = "Jocimara",
                Sobrenome = "Magalhaes",
                Telefone = "(65)9999-8888"
            },
             new Aluno(){
                 Id = 3,
                Nome = "Maria",
                Sobrenome = "Silva",
                Telefone = "(65)9999-7777"
            },

        };
        public AlunoController()
        {
            
        }

        [HttpGet]
        public IActionResult Get()
        {
            return  Ok(Alunos);
        }

         [HttpGet("byId")]
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null) return BadRequest("O Aluno não foi encontrado!");

            return  Ok(aluno);
        }

        [HttpGet("byName")]
        public IActionResult GetByNome(string nome, string sobrenome)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Nome.Contains(nome) 
                                                && a.Sobrenome.Contains(sobrenome));
            if (aluno == null) return BadRequest("O Aluno não foi encontrado!");

            return  Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            return  Ok(aluno);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            return  Ok(aluno);
        }
        
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            return  Ok(aluno);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return  Ok();
        }
    }
}