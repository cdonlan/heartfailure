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
    public class ExtendedActivityEventsTablesController : Controller
    {
        private TrackingSampleEntities db = new TrackingSampleEntities();

        // GET: ExtendedActivityEventsTables
        public ActionResult Index()
        {
            return View(db.ExtendedActivityEventsTables.ToList());
        }

        // GET: ExtendedActivityEventsTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExtendedActivityEventsTable extendedActivityEventsTable = db.ExtendedActivityEventsTables.Find(id);
            if (extendedActivityEventsTable == null)
            {
                return HttpNotFound();
            }
            return View(extendedActivityEventsTable);
        }

        // GET: ExtendedActivityEventsTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExtendedActivityEventsTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,WorkflowInstanceId,RecordNumber,TraceLevelId,ActivityRecordType,ActivityName,ActivityId,ActivityInstanceId,ActivityType,ChildActivityName,ChildActivityId,ChildActivityInstanceId,ChildActivityType,FaultDetails,FaultHandlerActivityName,FaultHandlerActivityId,FaultHandlerActivityInstanceId,FaultHandlerActivityType,SerializedAnnotations,TimeCreated")] ExtendedActivityEventsTable extendedActivityEventsTable)
        {
            if (ModelState.IsValid)
            {
                db.ExtendedActivityEventsTables.Add(extendedActivityEventsTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(extendedActivityEventsTable);
        }

        // GET: ExtendedActivityEventsTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExtendedActivityEventsTable extendedActivityEventsTable = db.ExtendedActivityEventsTables.Find(id);
            if (extendedActivityEventsTable == null)
            {
                return HttpNotFound();
            }
            return View(extendedActivityEventsTable);
        }

        // POST: ExtendedActivityEventsTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,WorkflowInstanceId,RecordNumber,TraceLevelId,ActivityRecordType,ActivityName,ActivityId,ActivityInstanceId,ActivityType,ChildActivityName,ChildActivityId,ChildActivityInstanceId,ChildActivityType,FaultDetails,FaultHandlerActivityName,FaultHandlerActivityId,FaultHandlerActivityInstanceId,FaultHandlerActivityType,SerializedAnnotations,TimeCreated")] ExtendedActivityEventsTable extendedActivityEventsTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(extendedActivityEventsTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(extendedActivityEventsTable);
        }

        // GET: ExtendedActivityEventsTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExtendedActivityEventsTable extendedActivityEventsTable = db.ExtendedActivityEventsTables.Find(id);
            if (extendedActivityEventsTable == null)
            {
                return HttpNotFound();
            }
            return View(extendedActivityEventsTable);
        }

        // POST: ExtendedActivityEventsTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ExtendedActivityEventsTable extendedActivityEventsTable = db.ExtendedActivityEventsTables.Find(id);
            db.ExtendedActivityEventsTables.Remove(extendedActivityEventsTable);
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
