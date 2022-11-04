using System;
using AspNetMVC.Data;

namespace AspNetMVC.Models
{
    public class Aluno
    {
        public string? Nome { get; set; }
        public string? Matricula { get; set; }
        public string? Situacao { get; set; }

        private DAAluno? DAAluno { get; set; }

        public Aluno()
        {
        }

        public List<Aluno> BuscarTodos()
        {
            DAAluno = new DAAluno();
            return DAAluno.alunos;
        }
    }
}

