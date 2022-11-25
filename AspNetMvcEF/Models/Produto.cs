using System;
namespace AspNetMvcEF.Models
{
	public class Produto
	{
		public int Id { get; set; }
		public string? Sku { get; set; }
		public string? Descricao { get; set; }
		public double Peso { get; set; }
		public double PrecoCusto { get; set; }
		public double PrecoVenda { get; set; }
		public DateTime Validade { get; set; }
	}
}

