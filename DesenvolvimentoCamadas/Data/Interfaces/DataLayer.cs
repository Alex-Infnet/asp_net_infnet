using System;
using System.Collections.Generic;
using DesenvolvimentoCamadas.Models;

namespace DesenvolvimentoCamadas.Data.Interfaces
{
    public interface DataLayer
    {
        List<Aluno> alunos { get; }

        void CalcularResultado();
    }
}

