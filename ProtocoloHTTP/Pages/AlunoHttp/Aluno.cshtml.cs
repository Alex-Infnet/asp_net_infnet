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

namespace ProtocoloHTTP.Pages.AlunoHttp
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
    }
}
