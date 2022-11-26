using System;
using Microsoft.EntityFrameworkCore;

namespace AspNetMvcEF.Models
{
	public class ModelContext : DbContext
	{
		public DbSet<Produto> produtos { get; set; }

		public ModelContext(DbContextOptions options) : base(options)
		{
		}
	}
}

