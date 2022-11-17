using System;
namespace AspNetDependencyInjection.Models
{
	public class Programa
	{
		public int Id { get; set; }
		public string? Nome { get; set; }
		public string? HorarioInicio { get; set; }
		public double Duracao { get; set; }
		public string? HorarioTermino {
			get{
				var hour = HorarioInicio?.Substring(0, 2);
				var minutes = HorarioInicio?.Substring(3, 2);
                var timeMoment = DateTime.Now.Date + (new TimeSpan(Convert.ToInt32(hour), Convert.ToInt32(minutes), 0));
                return timeMoment.AddMinutes(Duracao).ToString("HH:mm");
            } }

		public Programa Buscar()
		{
			return new Programa()
			{
				Id = 1,
				Nome = "Programa novo",
				HorarioInicio = "19:00",
				Duracao = 120
			};
		}

        public List<Programa> BuscarProgramas()
        {
			var progs = new List<Programa>();
			progs.Add(
                new Programa()
                {
                    Id = 1,
                    Nome = "Programa antigo",
                    HorarioInicio = "16:00",
                    Duracao = 180
                }
				);
            progs.Add(
                new Programa()
                {
                    Id = 1,
                    Nome = "Programa novo",
                    HorarioInicio = "19:00",
                    Duracao = 120
                }
                );
            return progs;
        }
    }
}

