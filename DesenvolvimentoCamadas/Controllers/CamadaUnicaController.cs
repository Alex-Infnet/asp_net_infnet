using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DesenvolvimentoCamadas.Controllers
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
    }
    public class Resultado
    {
        public string Status { get; set; }
    }
    public class Historico
    {
        public string Status { get; set; }
    }
    public class CamadaUnicaController : Controller
    {
        public List<Aluno> alunos { get; set; }
        public CamadaUnicaController()
        {
            alunos = new List<Aluno>();
            alunos.Add(new Aluno(1, "Aluno 1", "aluno1@email.com.br", "Matriculado", 0.9, 7.5));
            alunos.Add(new Aluno(2, "Aluno 2", "aluno2@email.com.br", "Trancado", 0.5, 0));
            alunos.Add(new Aluno(3, "Aluno 3", "aluno3@email.com.br", "Matriculado", 0.6, 5.5));
        }

        [HttpGet]
        public JsonResult CalcularResultado(int Id)
        {
            /* - User Story
             * Como um administrador de Universidade
             * Eu desejo saber se um aluno foi aprovado ou nao
             * Para atualizar o historico desse aluno.
             * 
             * - Regras
             * O aluno precisa estar matriculado
             * Para o aluno nao matriculado deve ser retornado vazio
             * O aluno para ser aprovado precisa ter frequencia maior ou igual a 75%
             * O aluno para ser aprovado precisa ter nota superior a 5
             */

            var aluno = alunos.First(a => a.Id == Id);
            if (aluno.Situacao != "Matriculado")
            {
                return new JsonResult(aluno);
            }
            aluno.Resultado.Status = "Aprovado";
            if (aluno.Frequencia < 0.75)
            {
                aluno.Resultado.Status = "Reprovado";
            }
            if (aluno.Nota < 5)
            {
                aluno.Resultado.Status = "Reprovado";
            }
            return new JsonResult(aluno);
        }

        [HttpGet]
        public JsonResult CalcularResultadoTodosAlunos()
        {
            foreach (var aluno in alunos)
            {
                if (aluno.Situacao == "Matriculado")
                {
                    aluno.Resultado.Status = "Aprovado";
                    if (aluno.Frequencia < 0.75)
                    {
                        aluno.Resultado.Status = "Reprovado";
                    }
                    if (aluno.Nota < 5)
                    {
                        aluno.Resultado.Status = "Reprovado";
                    }
                }
            }
            return new JsonResult(alunos);
        }
    }
}

