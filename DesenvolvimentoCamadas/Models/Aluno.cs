using System;
using DesenvolvimentoCamadas.Controllers;

namespace DesenvolvimentoCamadas.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public double Nota { get; set; }
        public double Frequencia { get; set; }
        public string Situacao { get; set; }
        public Resultado Resultado { get; set; }
        public Aluno(int _Id, string _Nome, string _Email, string _Situacao, double _Frequencia, double _Nota)
        {
            Id = _Id;
            Nome = _Nome;
            Email = _Email;
            Situacao = _Situacao;
            Frequencia = _Frequencia;
            Nota = _Nota;
            Resultado = new Resultado();
        }
        public void CalcularResultado()
        {
            if (this.Situacao != "Matriculado")
            {
                return;
            }
            this.Resultado.Status = "Aprovado";
            if (this.Frequencia < 0.75)
            {
                this.Resultado.Status = "Reprovado";
            }
            if (this.Nota < 5)
            {
                this.Resultado.Status = "Reprovado";
            }
        }
    }
}

