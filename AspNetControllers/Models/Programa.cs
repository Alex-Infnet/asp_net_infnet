using System;
namespace AspNetControllers.Models
{
    public class Programa
    {
        public string? Nome { get; set; }
        public string? Genero { get; set; }
        public string? Horario { get; set; }
        public string? Duracao { get; set; }

        public List<Programa> Programas()
        {
            var prog = new Programa()
            {
                Nome = "Programa 1",
                Genero = "Humor",
                Horario = "19:00",
                Duracao = "2 horas"
            };
            var progs = new List<Programa>()
            {
                prog
            };
            return progs;
        }
    }
}

