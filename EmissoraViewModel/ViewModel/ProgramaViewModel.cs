using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmissoraViewModel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmissoraViewModel.ViewModel
{
    public class ProgramaViewModel
    {
        public string? NomePrograma { get; set; }
        public string? NomeApresentador { get; set; }
        public List<ProgramaViewModel> BuscarProgramas()
        {
            var progs = new List<Programa>()
            {
                new Programa()
                {
                    Nome = "Programa",
                    Apresentador = new Apresentador()
                    {
                        Nome = "Joao"
                    }
                }
            };

            var listProgs = new List<ProgramaViewModel>();
            foreach (var prog in progs)
            {
                listProgs.Add(
                    new ProgramaViewModel()
                    {
                        NomeApresentador = prog.Apresentador?.Nome,
                        NomePrograma = prog.Nome
                    });
            };
            return listProgs;
        }
    }
}
