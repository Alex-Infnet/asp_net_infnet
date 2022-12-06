using System;
namespace Campeonato.Models
{
	public class Competicao
	{
		public List<Time> times { get; set; }

		public Competicao()
		{
			times = new List<Time>();
			times.Add(new Time()
			{
				Nome = "Time A",
				GolsFeitos = 10,
				GolsSofridos = 2
			});
            times.Add(new Time()
            {
                Nome = "Time B",
                GolsFeitos = 1,
                GolsSofridos = 2
            });
            times.Add(new Time()
            {
                Nome = "Time C",
                GolsFeitos = 3,
                GolsSofridos = 2
            });
        }

        public Competicao(List<Time> _times)
        {
            times = _times;
        }

        public List<Time> Classificados()
        {
            return times.OrderByDescending(t => t.SaldoGols()).Take(2).ToList();
        }

        public List<Time> ClassificadosComMaisGols()
        {
            return times.OrderByDescending(t => t.GolsFeitos).Take(2).ToList();
        }
	}
}

