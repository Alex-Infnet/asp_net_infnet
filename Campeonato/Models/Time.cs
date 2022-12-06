using System;
namespace Campeonato.Models
{
	public class Time
	{
		public string? Nome { get; set; }
		public int GolsFeitos { get; set; }
		public int GolsSofridos { get; set; }

        public int SaldoGols()
        {
            return GolsFeitos - GolsSofridos;
        }
    }

}

