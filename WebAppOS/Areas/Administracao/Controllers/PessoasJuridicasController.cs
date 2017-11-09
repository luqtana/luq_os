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
    public class PessoasJuridicasController : Controller
    {
        private Contexto db = new Contexto();

        // GET: Administracao/PessoasJuridicas
        public ActionResult Index()
        {
            return View(db.PessoasJuridicas.ToList());
        }

        // GET: Administracao/PessoasJuridicas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pessoaJuridica = db.PessoasJuridicas.Find(id);
            if (pessoaJuridica == null)
            {
                return HttpNotFound();
            }
            return View(pessoaJuridica);
        }

        // GET: Administracao/PessoasJuridicas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administracao/PessoasJuridicas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PessoaJuridica pessoaJuridica)
        {
            if (ModelState.IsValid)
            {
                db.PessoasJuridicas.Add(pessoaJuridica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pessoaJuridica);
        }

        // GET: Administracao/PessoasJuridicas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pessoaJuridica = db.PessoasJuridicas.Find(id);
            if (pessoaJuridica == null)
            {
                return HttpNotFound();
            }
            return View(pessoaJuridica);
        }

        // POST: Administracao/PessoasJuridicas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PessoaJuridica pessoaJuridica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pessoaJuridica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pessoaJuridica);
        }

        // GET: Administracao/PessoasJuridicas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pessoaJuridica = db.PessoasJuridicas.Find(id);
            if (pessoaJuridica == null)
            {
                return HttpNotFound();
            }
            return View(pessoaJuridica);
        }

        // POST: Administracao/PessoasJuridicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var pessoaJuridica = db.PessoasJuridicas.Find(id);
            db.PessoasJuridicas.Remove(pessoaJuridica);
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
