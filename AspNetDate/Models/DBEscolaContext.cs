using System;
using Microsoft.EntityFrameworkCore;

namespace AspNetDate.Models
{
	public class DBEscolaContext : DbContext
	{
        public DbSet<Escola> DBEscola { get; set; }

        public DBEscolaContext(DbContextOptions<DBEscolaContext> options) : base(options)
        {
        }
	}
}

