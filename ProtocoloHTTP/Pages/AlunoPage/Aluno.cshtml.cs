using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProtocoloHTTP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
/*
 * 
 * https://www.amitph.com/http-put-vs-patch/
 * 
 */

namespace ProtocoloHTTP.Pages
{
    public class AlunoPageModel : PageModel
    {
        public List<Aluno> alunos;
        public Aluno selectedAluno;
        public AlunoPageModel()
        {
            alunos = new List<Aluno>();
            alunos.Add(new Aluno(1, "Aluno 1", "aluno1@email.com.br"));
            alunos.Add(new Aluno(2, "Aluno 2", "aluno2@email.com.br"));
            alunos.Add(new Aluno(3, "Aluno 3", "aluno3@email.com.br"));
        }
        public void OnGet()
        {
        }
        public void OnGet(int Id)
        {
            selectedAluno = alunos.First(a => a.Id == Id);
        }
        public void OnPost([FromBody] Aluno aluno)
        {
            alunos.Add(aluno);
            /*alunos.Save*/
        }
        public void OnPut(int Id, [FromBody] Aluno aluno)
        {
            var alunoToBeUpdated = alunos.First(a => a.Id == Id);
            alunoToBeUpdated.Email = aluno.Email;
            alunoToBeUpdated.Nome = aluno.Nome;
            /*alunoToBeUpdated.Save*/
        }
        public void OnPatch(int Id, [FromBody] Aluno aluno)
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
            /*alunoToBeUpdated.Save*/
        }
        public void OnDelete(int Id)
        {
            alunos.Remove(alunos.First(a => a.Id == Id));
            /*alunos.Save*/
        }
    }
}
