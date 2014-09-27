using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HeartFailureReaddminssion.Models.WorkflowTracking;

namespace HeartFailureReaddminssion.Controllers.WorkflowTracking
{
    public class WorkflowInstanceEventsTablesController : Controller
    {
        private TrackingSampleEntities db = new TrackingSampleEntities();

        // GET: WorkflowInstanceEventsTables
        public ActionResult Index()
        {
            return View(db.WorkflowInstanceEventsTables.ToList());
        }

        // GET: WorkflowInstanceEventsTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkflowInstanceEventsTable workflowInstanceEventsTable = db.WorkflowInstanceEventsTables.Find(id);
            if (workflowInstanceEventsTable == null)
            {
                return HttpNotFound();
            }
            return View(workflowInstanceEventsTable);
        }

        // GET: WorkflowInstanceEventsTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WorkflowInstanceEventsTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,WorkflowInstanceId,WorkflowActivityDefinition,RecordNumber,State,TraceLevelId,Reason,ExceptionDetails,SerializedAnnotations,TimeCreated")] WorkflowInstanceEventsTable workflowInstanceEventsTable)
        {
            if (ModelState.IsValid)
            {
                db.WorkflowInstanceEventsTables.Add(workflowInstanceEventsTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(workflowInstanceEventsTable);
        }

        // GET: WorkflowInstanceEventsTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkflowInstanceEventsTable workflowInstanceEventsTable = db.WorkflowInstanceEventsTables.Find(id);
            if (workflowInstanceEventsTable == null)
            {
                return HttpNotFound();
            }
            return View(workflowInstanceEventsTable);
        }

        // POST: WorkflowInstanceEventsTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,WorkflowInstanceId,WorkflowActivityDefinition,RecordNumber,State,TraceLevelId,Reason,ExceptionDetails,SerializedAnnotations,TimeCreated")] WorkflowInstanceEventsTable workflowInstanceEventsTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(workflowInstanceEventsTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(workflowInstanceEventsTable);
        }

        // GET: WorkflowInstanceEventsTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkflowInstanceEventsTable workflowInstanceEventsTable = db.WorkflowInstanceEventsTables.Find(id);
            if (workflowInstanceEventsTable == null)
            {
                return HttpNotFound();
            }
            return View(workflowInstanceEventsTable);
        }

        // POST: WorkflowInstanceEventsTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WorkflowInstanceEventsTable workflowInstanceEventsTable = db.WorkflowInstanceEventsTables.Find(id);
            db.WorkflowInstanceEventsTables.Remove(workflowInstanceEventsTable);
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
