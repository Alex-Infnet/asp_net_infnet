using System;
using Microsoft.EntityFrameworkCore;

namespace LojaHandsOn.Models
{
	public class LojaContext : DbContext
	{
		public LojaContext(DbContextOptions<LojaContext> options) : base(options)
		{
		}
	}
}

