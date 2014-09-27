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
    public class CustomTrackingEventsTablesController : Controller
    {
        private TrackingSampleEntities db = new TrackingSampleEntities();

        // GET: CustomTrackingEventsTables
        public ActionResult Index()
        {
            return View(db.CustomTrackingEventsTables.ToList());
        }

        // GET: CustomTrackingEventsTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomTrackingEventsTable customTrackingEventsTable = db.CustomTrackingEventsTables.Find(id);
            if (customTrackingEventsTable == null)
            {
                return HttpNotFound();
            }
            return View(customTrackingEventsTable);
        }

        // GET: CustomTrackingEventsTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomTrackingEventsTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,WorkflowInstanceId,RecordNumber,TraceLevelId,CustomRecordName,ActivityName,ActivityId,ActivityInstanceId,ActivityType,SerializedData,SerializedAnnotations,TimeCreated")] CustomTrackingEventsTable customTrackingEventsTable)
        {
            if (ModelState.IsValid)
            {
                db.CustomTrackingEventsTables.Add(customTrackingEventsTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customTrackingEventsTable);
        }

        // GET: CustomTrackingEventsTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomTrackingEventsTable customTrackingEventsTable = db.CustomTrackingEventsTables.Find(id);
            if (customTrackingEventsTable == null)
            {
                return HttpNotFound();
            }
            return View(customTrackingEventsTable);
        }

        // POST: CustomTrackingEventsTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,WorkflowInstanceId,RecordNumber,TraceLevelId,CustomRecordName,ActivityName,ActivityId,ActivityInstanceId,ActivityType,SerializedData,SerializedAnnotations,TimeCreated")] CustomTrackingEventsTable customTrackingEventsTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customTrackingEventsTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customTrackingEventsTable);
        }

        // GET: CustomTrackingEventsTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomTrackingEventsTable customTrackingEventsTable = db.CustomTrackingEventsTables.Find(id);
            if (customTrackingEventsTable == null)
            {
                return HttpNotFound();
            }
            return View(customTrackingEventsTable);
        }

        // POST: CustomTrackingEventsTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CustomTrackingEventsTable customTrackingEventsTable = db.CustomTrackingEventsTables.Find(id);
            db.CustomTrackingEventsTables.Remove(customTrackingEventsTable);
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
