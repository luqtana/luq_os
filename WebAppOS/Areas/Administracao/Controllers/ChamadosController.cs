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
    public class ChamadosController : Controller
    {
        private Contexto db = new Contexto();

        // GET: Administracao/Chamados
        public ActionResult Index()
        {
            var chamados = db.Chamados.Include(c => c.Pessoa).Include(c => c.Tecnico);
            return View(chamados.ToList());
        }

        // GET: Administracao/Chamados/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chamado chamado = db.Chamados.Find(id);
            if (chamado == null)
            {
                return HttpNotFound();
            }
            return View(chamado);
        }

        // GET: Administracao/Chamados/Create
        public ActionResult Create()
        {
            ViewBag.PessoaId = new SelectList(db.Pessoas, "PessoaId", "Nome");
            ViewBag.TecnicoId = new SelectList(db.Tecnicos, "TecnicoId", "Nome");
            return View();
        }

        // POST: Administracao/Chamados/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Chamado chamado)
        {
            if (ModelState.IsValid)
            {
                db.Chamados.Add(chamado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PessoaId = new SelectList(db.Pessoas, "PessoaId", "Nome", chamado.PessoaId);
            ViewBag.TecnicoId = new SelectList(db.Tecnicos, "TecnicoId", "Nome", chamado.TecnicoId);
            return View(chamado);
        }

        // GET: Administracao/Chamados/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chamado chamado = db.Chamados.Find(id);
            if (chamado == null)
            {
                return HttpNotFound();
            }
            ViewBag.PessoaId = new SelectList(db.Pessoas, "PessoaId", "Nome", chamado.PessoaId);
            ViewBag.TecnicoId = new SelectList(db.Tecnicos, "TecnicoId", "Nome", chamado.TecnicoId);
            return View(chamado);
        }

        // POST: Administracao/Chamados/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Chamado chamado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chamado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PessoaId = new SelectList(db.Pessoas, "PessoaId", "Nome", chamado.PessoaId);
            ViewBag.TecnicoId = new SelectList(db.Tecnicos, "TecnicoId", "Nome", chamado.TecnicoId);
            return View(chamado);
        }

        // GET: Administracao/Chamados/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chamado chamado = db.Chamados.Find(id);
            if (chamado == null)
            {
                return HttpNotFound();
            }
            return View(chamado);
        }

        // POST: Administracao/Chamados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Chamado chamado = db.Chamados.Find(id);
            db.Chamados.Remove(chamado);
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
