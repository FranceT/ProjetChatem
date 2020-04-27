using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjetChatem.Models;

namespace ProjetChatem.Controllers
{
    public class UtilisateursController : Controller
    {
        private bdchatemEntities db = new bdchatemEntities();

        // GET: Utilisateurs
        public ActionResult Index()
        {
            var utilisateurs = db.Utilisateurs.Include(u => u.TypeUtilisateur);
            return View(utilisateurs.ToList());
        }

        // GET: Utilisateurs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Utilisateur utilisateur = db.Utilisateurs.Find(id);
            if (utilisateur == null)
            {
                return HttpNotFound();
            }
            return View(utilisateur);
        }

        // GET: Utilisateurs/Create
        public ActionResult Create()
        {
            ViewBag.nomtypeUtilisateur = new SelectList(db.TypeUtilisateurs, "identifiantUtilisateur", "nomtypeUtilisateur");
            return View();
        }

        // POST: Utilisateurs/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "numUtilisateur,nomUtilisateur,numTelephone,courriel,profession,villeResidence,paysOrigine,visibiliteInfos,nomtypeUtilisateur,motDePasse")] Utilisateur utilisateur)
        {
            if (ModelState.IsValid)
            {
                db.Utilisateurs.Add(utilisateur);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.nomtypeUtilisateur = new SelectList(db.TypeUtilisateurs, "identifiantUtilisateur", "nomtypeUtilisateur", utilisateur.nomtypeUtilisateur);
            return View(utilisateur);
        }

        // GET: Utilisateurs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Utilisateur utilisateur = db.Utilisateurs.Find(id);
            if (utilisateur == null)
            {
                return HttpNotFound();
            }
            ViewBag.nomtypeUtilisateur = new SelectList(db.TypeUtilisateurs, "identifiantUtilisateur", "nomtypeUtilisateur", utilisateur.nomtypeUtilisateur);
            return View(utilisateur);
        }

        // POST: Utilisateurs/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "numUtilisateur,nomUtilisateur,numTelephone,courriel,profession,villeResidence,paysOrigine,visibiliteInfos,nomtypeUtilisateur,motDePasse")] Utilisateur utilisateur)
        {
            if (ModelState.IsValid)
            {
                db.Entry(utilisateur).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.nomtypeUtilisateur = new SelectList(db.TypeUtilisateurs, "identifiantUtilisateur", "nomtypeUtilisateur", utilisateur.nomtypeUtilisateur);
            return View(utilisateur);
        }

        // GET: Utilisateurs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Utilisateur utilisateur = db.Utilisateurs.Find(id);
            if (utilisateur == null)
            {
                return HttpNotFound();
            }
            return View(utilisateur);
        }

        // POST: Utilisateurs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Utilisateur utilisateur = db.Utilisateurs.Find(id);
            db.Utilisateurs.Remove(utilisateur);
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
