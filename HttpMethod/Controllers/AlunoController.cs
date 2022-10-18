using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HttpMethod.Models;

namespace HttpMethod.Controllers
{
    public class AlunoController : Controller
    {
        public List<Aluno> alunos;
        public Aluno selectedAluno;
        public AlunoController()
        {
            alunos = new List<Aluno>();
            alunos.Add(new Aluno(1, "Aluno 1", "aluno1@email.com.br"));
            alunos.Add(new Aluno(2, "Aluno 2", "aluno2@email.com.br"));
            alunos.Add(new Aluno(3, "Aluno 3", "aluno3@email.com.br"));
        }
        [HttpGet]
        public IActionResult Get(int? Id)
        {
            if (Id != null)
            {
                return View("Details", alunos.First(a => a.Id == Id));
            }
            return View("Get", alunos);
        }
        [HttpGet]
        public IActionResult New()
        {
            return View("Details", new Aluno());
        }
        [HttpPost]
        public IActionResult Post([FromBody] Aluno aluno)
        {
            alunos.Add(aluno);
            return View("Get", alunos);
        }
        [HttpPost]
        public IActionResult PostFromForm([FromForm] Aluno aluno)
        {
            aluno.Id = alunos.Count + 1;
            alunos.Add(aluno);
            return View("Get", alunos);
        }
        [HttpPut]
        public IActionResult Put(int Id, [FromBody] Aluno aluno)
        {
            var alunoToBeUpdated = alunos.First(a => a.Id == Id);
            alunoToBeUpdated.Email = aluno.Email;
            alunoToBeUpdated.Nome = aluno.Nome;
            return View("Get", alunos);
        }
        [HttpPatch]
        public IActionResult Patch(int Id, [FromBody] Aluno aluno)
        {
            var alunoToBeUpdated = alunos.First(a => a.Id == Id);
            if (!String.IsNullOrEmpty(aluno.Email))
            {
                alunoToBeUpdated.Email = aluno.Email;
            }
            if (!String.IsNullOrEmpty(aluno.Nome))
            {
                alunoToBeUpdated.Nome = aluno.Nome;
            }
            return View("Get", alunos);
        }
        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            alunos.Remove(alunos.First(a => a.Id == Id));
            return View("Get", alunos);
        }
    }
}

