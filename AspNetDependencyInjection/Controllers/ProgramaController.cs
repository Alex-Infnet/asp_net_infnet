using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetDependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetDependencyInjection.Controllers
{
    public class ProgramaController : Controller
    {
        public readonly Programa _programa;
        public ProgramaController(Programa programa)
        {
            _programa = programa;
        }
        public IActionResult ListaDeProgramasHtml()
        {
            ViewBag.Programas = _programa.BuscarProgramas();
            ViewBag.Erro = "Ocorreu um erro ao consultar a lista de programas";
            return View();
        }
        public IActionResult ListaDeProgramasJson()
        {
            var listProgramas = _programa.BuscarProgramas();
            if (listProgramas.Count == 2)
            {
                return BadRequest("Ocorreu um erro ao consultar a lista de programas");
            }
            return Ok(listProgramas);
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Programa = _programa.Buscar();
            return View();
        }
    }
}

