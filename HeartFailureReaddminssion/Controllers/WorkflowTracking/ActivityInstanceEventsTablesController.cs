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
    public class ActivityInstanceEventsTablesController : Controller
    {
        private TrackingSampleEntities db = new TrackingSampleEntities();

        // GET: ActivityInstanceEventsTables
        public ActionResult Index()
        {
            return View(db.ActivityInstanceEventsTables.ToList());
        }

        // GET: ActivityInstanceEventsTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActivityInstanceEventsTable activityInstanceEventsTable = db.ActivityInstanceEventsTables.Find(id);
            if (activityInstanceEventsTable == null)
            {
                return HttpNotFound();
            }
            return View(activityInstanceEventsTable);
        }

        // GET: ActivityInstanceEventsTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ActivityInstanceEventsTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,WorkflowInstanceId,RecordNumber,State,TraceLevelId,ActivityRecordType,ActivityName,ActivityId,ActivityInstanceId,ActivityType,SerializedArguments,SerializedVariables,SerializedAnnotations,TimeCreated")] ActivityInstanceEventsTable activityInstanceEventsTable)
        {
            if (ModelState.IsValid)
            {
                db.ActivityInstanceEventsTables.Add(activityInstanceEventsTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(activityInstanceEventsTable);
        }

        // GET: ActivityInstanceEventsTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActivityInstanceEventsTable activityInstanceEventsTable = db.ActivityInstanceEventsTables.Find(id);
            if (activityInstanceEventsTable == null)
            {
                return HttpNotFound();
            }
            return View(activityInstanceEventsTable);
        }

        // POST: ActivityInstanceEventsTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,WorkflowInstanceId,RecordNumber,State,TraceLevelId,ActivityRecordType,ActivityName,ActivityId,ActivityInstanceId,ActivityType,SerializedArguments,SerializedVariables,SerializedAnnotations,TimeCreated")] ActivityInstanceEventsTable activityInstanceEventsTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(activityInstanceEventsTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(activityInstanceEventsTable);
        }

        // GET: ActivityInstanceEventsTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActivityInstanceEventsTable activityInstanceEventsTable = db.ActivityInstanceEventsTables.Find(id);
            if (activityInstanceEventsTable == null)
            {
                return HttpNotFound();
            }
            return View(activityInstanceEventsTable);
        }

        // POST: ActivityInstanceEventsTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ActivityInstanceEventsTable activityInstanceEventsTable = db.ActivityInstanceEventsTables.Find(id);
            db.ActivityInstanceEventsTables.Remove(activityInstanceEventsTable);
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
