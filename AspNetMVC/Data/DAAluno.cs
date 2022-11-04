using System;
using AspNetMVC.Models;

namespace AspNetMVC.Data
{
    public class DAAluno
    {
        public List<Aluno> alunos;
        public DAAluno()
        {
            alunos = new List<Aluno>();
            alunos.Add(new Aluno()
            {
                 Matricula = "202202",
                 Nome = "Aluno 1",
                 Situacao = "Matriculado"
            });
            alunos.Add(new Aluno()
            {
                Matricula = "202203",
                Nome = "Aluno 2",
                Situacao = "Matriculado"
            });
            alunos.Add(new Aluno()
            {
                Matricula = "202204",
                Nome = "Aluno 3",
                Situacao = "Trancado"
            });
        }
    }
}

