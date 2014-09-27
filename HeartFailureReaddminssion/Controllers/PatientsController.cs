using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HeartFailureReaddminssion.Models;
using HeartFailureReaddminssion.Workflow;
using System.Activities;
using Microsoft.Samples.SqlTracking;


namespace HeartFailureReaddminssion.Controllers
{
    public class PatientsController : Controller
    {
        private HeartFailureDBModel db = new HeartFailureDBModel();

        // GET: Patients
        public ActionResult Index()
        {
            return View(db.Patients.ToList());
        }

        // GET: Patients/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patient patient = db.Patients.Find(id);
            if (patient == null)
            {
                return HttpNotFound();
            }
            return View(patient);
        }

        // GET: Patients/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Patients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,EncounterID,FirstName,LastName,Admitted,Discharge,AdmittedLocation")] Patient patient)
        {
            if (ModelState.IsValid)
            {
                db.Patients.Add(patient);
                db.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(patient);
        }

        // GET: Patients/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patient patient = db.Patients.Find(id);
            if (patient == null)
            {
                return HttpNotFound();
            }
            return View(patient);
        }

        // POST: Patients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,EncounterID,FirstName,LastName,Admitted,Discharge,AdmittedLocation")] Patient patient)
        {
            if (ModelState.IsValid)
            {
                db.Entry(patient).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(patient);
        }

        // GET: Patients/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patient patient = db.Patients.Find(id);
            if (patient == null)
            {
                return HttpNotFound();
            }
            return View(patient);
        }

        // POST: Patients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Patient patient = db.Patients.Find(id);
            db.Patients.Remove(patient);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult StartWorkflow(int id)
        {
            Patient patient = db.Patients.Find(id);
            string patientWorkflowValues;

            //Create workflow
            HeartFail wf = new HeartFail();
            var input = new Dictionary<string, object>();
            input.Add("InputPatient", patient);
           
            //Add tracking 
            SqlTrackingParticipant sqlTracking = new SqlTrackingParticipant();
            sqlTracking.ConnectionString = System.Configuration.ConfigurationManager.
    ConnectionStrings["TrackingDbConnection"].ConnectionString;

            //Start workflow
            WorkflowInvoker invoker = new WorkflowInvoker(wf);
            
            invoker.Extensions.Add(sqlTracking);
            IDictionary<string, object> output = invoker.Invoke(input);


           if(output != null && output.Count > 0)
           {
           //    patientWorkflowValues = (string)output["Patient1"];
           }

            return View(patient);
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
