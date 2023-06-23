using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BlogMvcApp.Models;

namespace BlogMvcApp.Controllers
{
    public class ProjeController : Controller

    {
        private BlogContext db = new BlogContext();

        // GET: Proje
        [Authorize]
        public ActionResult Index()
        {
            var projeler = db.Projeler
                .OrderByDescending(i => i.ProjeTarihi);
            return View(projeler.ToList());
        }



        // GET: Proje/Details/5
        [Authorize]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proje proje = db.Projeler.Find(id);
            if (proje == null)
            {
                return HttpNotFound();
            }
            return View(proje);
        }

        // GET: Proje/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Proje/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create([Bind(Include = "ProjeAd,ProjeOzet,ProjeAciklama,ProjeGorsel")] Proje proje)
        {
            if (ModelState.IsValid)
            {
                proje.ProjeTarihi = DateTime.Now;

                db.Projeler.Add(proje);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(proje);
        }

        // GET: Proje/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proje proje = db.Projeler.Find(id);
            if (proje == null)
            {
                return HttpNotFound();
            }
            return View(proje);
        }

        // POST: Proje/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit([Bind(Include = "Id,ProjeAd,ProjeOzet,ProjeAciklama,ProjeGorsel")] Proje proje)
        {
            if (ModelState.IsValid)
            {
                var entity = db.Projeler.Find(proje.Id);
                if (entity != null)
                {
                    entity.ProjeAd = proje.ProjeAd;
                    entity.ProjeGorsel = proje.ProjeGorsel;
                    entity.ProjeOzet = proje.ProjeOzet;
                    entity.ProjeAciklama = proje.ProjeAciklama;


                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
            }
            return View(proje);
        }

        public ActionResult ProjelerHome()
        {
            var projeler = db.Projeler
                .OrderByDescending(i => i.ProjeTarihi);
                
            return View(projeler.ToList());
        }


        // GET: Proje/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proje proje = db.Projeler.Find(id);
            if (proje == null)
            {
                return HttpNotFound();
            }
            return View(proje);
        }

        // POST: Proje/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult DeleteConfirmed(int id)
        {
            Proje proje = db.Projeler.Find(id);
            db.Projeler.Remove(proje);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
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
