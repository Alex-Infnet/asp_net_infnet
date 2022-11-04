using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetMVC.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetMVC.Controllers
{
    public class AlunoController : Controller
    {
        public readonly Aluno aluno;
        public AlunoController(
            Aluno _aluno
            )
        {
            aluno = _aluno;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            // Define the view
            return View(aluno);
        }
    }
}

