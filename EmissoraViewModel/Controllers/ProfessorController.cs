using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmissoraViewModel.DataSource;
using EmissoraViewModel.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmissoraViewModel.Controllers
{
    public class ProfessorController : Controller
    {
        public readonly DAProfessor dAProfessor;
        public ProfessorController(DAProfessor _dAProfessor)
        {
            dAProfessor = _dAProfessor;
        }
        // GET: Professor
        public ActionResult Index()
        {
            return View(dAProfessor.professores);
        }

        // GET: Professor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Professor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Professor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Professor professor)
        {
            try
            {
                dAProfessor.professores.Add(professor);

                return View("Index", dAProfessor.professores);
            }
            catch
            {
                return View();
            }
        }

        // GET: Professor/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Professor/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Professor/Delete/5
        public ActionResult Delete(string Matricula)
        {
            dAProfessor.professores.Remove(
                dAProfessor.professores.First(p => p.Matricula == Matricula)
                );
            return View("Index", dAProfessor.professores);
        }

        // POST: Professor/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}