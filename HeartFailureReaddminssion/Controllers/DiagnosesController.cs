using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HeartFailureReaddminssion.Models;

namespace HeartFailureReaddminssion.Controllers
{
    public class DiagnosesController : Controller
    {
        private HeartFailureDBModel db = new HeartFailureDBModel();

        // GET: Diagnoses
        public ActionResult Index()
        {
            var diagnosis = db.Diagnosis.Include(d => d.Patient);
            return View(diagnosis.ToList());
        }

        // GET: Diagnoses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diagnosis diagnosis = db.Diagnosis.Find(id);
            if (diagnosis == null)
            {
                return HttpNotFound();
            }
            return View(diagnosis);
        }

        // GET: Diagnoses/Create
        public ActionResult Create()
        {
            ViewBag.PatientID = new SelectList(db.Patients, "ID", "FirstName");
            return View();
        }

        // POST: Diagnoses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DiagnosisID,EncounterID,LineNBR,ICD9DiagnosisCD,DiagnosisPOA,DiagnosisNM,DiagnosisGroupDSC,PatientID")] Diagnosis diagnosis)
        {
            if (ModelState.IsValid)
            {
                db.Diagnosis.Add(diagnosis);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PatientID = new SelectList(db.Patients, "ID", "FirstName", diagnosis.PatientID);
            return View(diagnosis);
        }

        // GET: Diagnoses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diagnosis diagnosis = db.Diagnosis.Find(id);
            if (diagnosis == null)
            {
                return HttpNotFound();
            }
            ViewBag.PatientID = new SelectList(db.Patients, "ID", "FirstName", diagnosis.PatientID);
            return View(diagnosis);
        }

        // POST: Diagnoses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DiagnosisID,EncounterID,LineNBR,ICD9DiagnosisCD,DiagnosisPOA,DiagnosisNM,DiagnosisGroupDSC,PatientID")] Diagnosis diagnosis)
        {
            if (ModelState.IsValid)
            {
                db.Entry(diagnosis).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PatientID = new SelectList(db.Patients, "ID", "FirstName", diagnosis.PatientID);
            return View(diagnosis);
        }

        // GET: Diagnoses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diagnosis diagnosis = db.Diagnosis.Find(id);
            if (diagnosis == null)
            {
                return HttpNotFound();
            }
            return View(diagnosis);
        }

        // POST: Diagnoses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Diagnosis diagnosis = db.Diagnosis.Find(id);
            db.Diagnosis.Remove(diagnosis);
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
