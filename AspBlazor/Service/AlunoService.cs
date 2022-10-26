using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspBlazor.Data;
namespace AspBlazor.Service
{
    public class AlunoService
    {
        List<Aluno> alunos { get; set; }
        public AlunoService()
        {
            alunos = new List<Aluno>();
            alunos.Add(new Aluno(1, "Nome do aluno1", "aluno1@email.com.br"));
            alunos.Add(new Aluno(2, "Nome do aluno2", "aluno2@email.com.br"));
            alunos.Add(new Aluno(3, "Nome do aluno3", "aluno3@email.com.br"));
        }
        public Task<List<Aluno>> getAlunos()
        {   
            return Task.FromResult<List<Aluno>>(alunos);
        }
        public void Remove(int Id)
        {
            alunos.Remove(alunos.Find(a => a.Id == Id));
        }
    }
}

