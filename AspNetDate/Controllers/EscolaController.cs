using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetDate.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetDate.Controllers
{
    public class EscolaController : Controller
    {
        public readonly DBEscolaContext DBEscolaContext;
        public EscolaController(DBEscolaContext context)
        {
            DBEscolaContext = context;
        }
        // GET: Escola
        public ActionResult Index()
        {
            return View();
        }

        // GET: Escola/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Escola/Create
        public ActionResult Create()
        {
            DBEscolaContext.DBEscola.Add(
                new Escola()
                {
                    DataCriacao = DateTime.Now,
                    Nome = "Escola com mesmo nome"
                });
            DBEscolaContext.SaveChanges();
            return View();
        }

        // POST: Escola/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Escola escola)
        {
            try
            {
                ViewBag.DataCriacao = escola.DataCriacao;

                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Escola/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Escola/Edit/5
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

        // GET: Escola/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Escola/Delete/5
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