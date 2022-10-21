using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesenvolvimentoCamadas.Data;
using DesenvolvimentoCamadas.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DesenvolvimentoCamadas.Controllers
{
    public class ResultadoController : Controller
    {
        private readonly DataLayer _dataAluno;
        public ResultadoController(DataLayer dataAluno)
        {
            _dataAluno = dataAluno;
        }
        [HttpGet]
        public JsonResult Get(int? Id)
        {
            if (Id != null)
            {
                var aluno = _dataAluno.alunos.First(a => a.Id == Id);
                aluno.CalcularResultado();
                return new JsonResult(aluno);
            }
            _dataAluno.CalcularResultado();
            return new JsonResult(_dataAluno.alunos);
        }
    }
}

