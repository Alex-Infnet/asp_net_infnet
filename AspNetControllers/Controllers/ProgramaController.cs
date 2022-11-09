using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetControllers.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetControllers.Controllers
{
    public class Test
    {
        public string Value { get; set; } = "Simple Case";
    }
    public class ProgramaController : Controller
    {
        public readonly Programa _programa;
        public ProgramaController(Programa programa)
        {
            _programa = programa;
        }
        // GET: /Programa/Programacao
        public IActionResult Programacao()
        {
            ViewBag.Programas = new List<string>()
            {
                "Bom dia com você",
                "Almoço e saúde",
                "Para descansar",
                "Boa noite em família"
            };
            return View("Programacao");
        }
        // GET: /Programa/ProgramaEspecifico
        public IActionResult ProgramaEspecifico()
        {
            ViewData["Programa"] = new List<string>()
            {
                "Para descansar",
                "Entretenimento",
                "17:00",
                "2 horas e 30 minutos"
            };
            return View("ProgramaEspecifico");
        }
        // GET: /Programa/AdicionarPrograma
        public IActionResult AdicionarPrograma()
        {
            return View("AdicionarPrograma");
        }
        // POST: /Programa/ResultadoAdicao
        public IActionResult ResultadoAdicao()
        {
            return View("ResultadoAdicao");
        }
        // GET: /Programa/Especificos
        public IActionResult Especificos()
        {
            return View("Programacao");
        }
        // GET: /Programa/ComHttpResponse
        public IActionResult ComHttpResponse(string Horario)
        {
            return Ok(_programa.Programas().First(p => p.Horario == Horario));
        }
    }
}

