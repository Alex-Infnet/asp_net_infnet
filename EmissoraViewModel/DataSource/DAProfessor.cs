using System;
using EmissoraViewModel.Models;

namespace EmissoraViewModel.DataSource
{
	public class DAProfessor
	{
		public List<Professor> professores { get; set; }
		public DAProfessor()
		{
			professores = new List<Professor>();
			var professor = new Professor()
			{
				Nome = "Professor 1",
				Matricula = "2022.00.234",
				Salario = 1000
			};
			professores.Add(professor);
            professor = new Professor()
            {
                Nome = "Professor 2",
                Matricula = "2020.01.254",
                Salario = 2500
            };
            professores.Add(professor);
            professor = new Professor()
            {
                Nome = "Professor 3",
                Matricula = "2002.00.102",
                Salario = 6500
            };
            professores.Add(professor);
        }
	}
}

