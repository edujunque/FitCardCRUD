using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FitCardCRUD.Models;

namespace FitCardCRUD.Controllers
{
    public class EstabelecimentoesController : Controller
    {
        private FitCardCRUDContext db = new FitCardCRUDContext();

        // GET: Estabelecimentoes
        public ActionResult Index()
        {
            return View(db.Estabelecimentoes.ToList());
        }

        // GET: Estabelecimentoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estabelecimento estabelecimento = db.Estabelecimentoes.Find(id);
            if (estabelecimento == null)
            {
                return HttpNotFound();
            }
            var categorias = db.Categorias.ToList();
            var viewModel = new ViewModel.EstabecimentoViewModel
            {
                Categorias = categorias,
                Estabelecimento = estabelecimento
            };
            return View(viewModel);
        }

        // GET: Estabelecimentoes/Create
        public ActionResult Create()
        {
            var categorias = db.Categorias.ToList();
            var viewModel = new ViewModel.EstabecimentoViewModel
            {
                Categorias = categorias
            };
            return View("Create", viewModel);
        }

        // POST: Estabelecimentoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,estabNome,estabNomeFantasia,estabCNPJ,estabEmail,estabTelefone,estabStatus,CategoriaId")] Estabelecimento estabelecimento)
        {
            if (ModelState.IsValid)
            {
                db.Estabelecimentoes.Add(estabelecimento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(estabelecimento);
        }

        // GET: Estabelecimentoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estabelecimento estabelecimento = db.Estabelecimentoes.Find(id);
            if (estabelecimento == null)
            {
                return HttpNotFound();
            }
            var categorias = db.Categorias.ToList();
            var viewModel = new ViewModel.EstabecimentoViewModel
            {
                Categorias = categorias,
                Estabelecimento = estabelecimento
            };
            return View(viewModel);
        }

        // POST: Estabelecimentoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,estabNome,estabNomeFantasia,estabCNPJ,estabEmail,estabTelefone,estabStatus,CategoriaId")] Estabelecimento estabelecimento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estabelecimento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(estabelecimento);
        }

        // GET: Estabelecimentoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estabelecimento estabelecimento = db.Estabelecimentoes.Find(id);
            if (estabelecimento == null)
            {
                return HttpNotFound();
            }
            var categorias = db.Categorias.ToList();
            var viewModel = new ViewModel.EstabecimentoViewModel
            {
                Categorias = categorias,
                Estabelecimento = estabelecimento
            };
            return View(viewModel);
        }

        // POST: Estabelecimentoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Estabelecimento estabelecimento = db.Estabelecimentoes.Find(id);
            db.Estabelecimentoes.Remove(estabelecimento);
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
