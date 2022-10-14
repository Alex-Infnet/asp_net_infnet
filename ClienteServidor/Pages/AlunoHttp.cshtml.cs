using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClienteServidor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClienteServidor.Pages
{
    public class AlunoHttpModel : PageModel
    {
        public List<Aluno> alunos;
        public AlunoHttpModel()
        {
            alunos = new List<Aluno>();
            alunos.Add(new Aluno(1, "Aluno 1", "aluno@email.com.br"));
            alunos.Add(new Aluno(2, "Aluno 2", "aluno@email.com.br"));
            alunos.Add(new Aluno(3, "Aluno 3", "aluno@email.com.br"));
        }
        public void OnGet()
        {

        }
    }
}
