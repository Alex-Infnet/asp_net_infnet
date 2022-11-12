using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetDI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetDI.Controllers
{
    public class Test
    {
        public string Value { get; set; } = "Simple Case";
    }
    public class ProgramaController : Controller
    {
        public IFile _file { get; set; }
        public ProgramaController(IFile file)
        {
            _file = file;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProgramaEspecifico()
        {
            ViewBag.Nome = "Programa inteligente";
            ViewBag.Horario = "19:00";

            // Create file
            _file.Create(DateTime.Now, ViewBag.Nome);

            return View("ProgramaEspecifico");
        }

        public IActionResult AdicionarPrograma()
        {
            return View();
        }
        public IActionResult Confirmacao(string Nome, string Horario)
        {
            Console.WriteLine(Nome);
            ViewBag.Nome = Nome;
            ViewBag.Horario = Horario;

            return View();
        }

        public IActionResult ProgramasJson()
        {
            var test = new Test();
            return Ok(test);
        }
    }
}

