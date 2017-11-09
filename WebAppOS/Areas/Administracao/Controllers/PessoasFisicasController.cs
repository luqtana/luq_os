using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAppOS.DAL;
using WebAppOS.Models;

namespace Areas.Administracao.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class PessoasFisicasController : Controller
    {
        private Contexto db = new Contexto();

        // GET: Administracao/PessoasFisicas
        public ActionResult Index()
        {
            return View(db.PessoasFisicas.ToList());
        }

        // GET: Administracao/PessoasFisicas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pessoaFisica = db.PessoasFisicas.Find(id);
            if (pessoaFisica == null)
            {
                return HttpNotFound();
            }
            return View(pessoaFisica);
        }

        // GET: Administracao/PessoasFisicas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administracao/PessoasFisicas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PessoaFisica pessoaFisica)
        {
            if (ModelState.IsValid)
            {
                db.PessoasFisicas.Add(pessoaFisica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pessoaFisica);
        }

        // GET: Administracao/PessoasFisicas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pessoaFisica = db.Pessoas.Find(id);
            if (pessoaFisica == null)
            {
                return HttpNotFound();
            }
            return View(pessoaFisica);
        }

        // POST: Administracao/PessoasFisicas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PessoaFisica pessoaFisica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pessoaFisica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pessoaFisica);
        }

        // GET: Administracao/PessoasFisicas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pessoaFisica = db.PessoasFisicas.Find(id);
            if (pessoaFisica == null)
            {
                return HttpNotFound();
            }
            return View(pessoaFisica);
        }

        // POST: Administracao/PessoasFisicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var pessoaFisica = db.PessoasFisicas.Find(id);
            db.PessoasFisicas.Remove(pessoaFisica);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
