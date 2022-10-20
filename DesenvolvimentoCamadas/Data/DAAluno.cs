using System;
using System.Collections.Generic;
using DesenvolvimentoCamadas.Data.Interfaces;
using DesenvolvimentoCamadas.Models;

namespace DesenvolvimentoCamadas.Data
{
    public class DAAluno : DataLayer
    {
        private List<Aluno> alunosData;
        public DAAluno()
        {
            alunosData = new List<Aluno>();
            alunosData.Add(new Aluno(1, "Aluno 1", "aluno1@email.com.br", "Matriculado", 0.9, 7.5));
            alunosData.Add(new Aluno(2, "Aluno 2", "aluno2@email.com.br", "Trancado", 0.5, 0));
            alunosData.Add(new Aluno(3, "Aluno 3", "aluno3@email.com.br", "Matriculado", 0.6, 5.5));
        }

        List<Aluno> DataLayer.alunos => alunosData;

        public void CalcularResultado()
        {
            foreach (var aluno in alunosData)
            {
                aluno.CalcularResultado();
            }
        }
    }
}

