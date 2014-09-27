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
    public class BookmarkResumptionEventsTablesController : Controller
    {
        private TrackingSampleEntities db = new TrackingSampleEntities();

        // GET: BookmarkResumptionEventsTables
        public ActionResult Index()
        {
            return View(db.BookmarkResumptionEventsTables.ToList());
        }

        // GET: BookmarkResumptionEventsTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookmarkResumptionEventsTable bookmarkResumptionEventsTable = db.BookmarkResumptionEventsTables.Find(id);
            if (bookmarkResumptionEventsTable == null)
            {
                return HttpNotFound();
            }
            return View(bookmarkResumptionEventsTable);
        }

        // GET: BookmarkResumptionEventsTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookmarkResumptionEventsTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,WorkflowInstanceId,RecordNumber,TraceLevelId,BookmarkName,BookmarkScope,OwnerActivityName,OwnerActivityId,OwnerActivityInstanceId,OwnerActivityType,SerializedAnnotations,TimeCreated")] BookmarkResumptionEventsTable bookmarkResumptionEventsTable)
        {
            if (ModelState.IsValid)
            {
                db.BookmarkResumptionEventsTables.Add(bookmarkResumptionEventsTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bookmarkResumptionEventsTable);
        }

        // GET: BookmarkResumptionEventsTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookmarkResumptionEventsTable bookmarkResumptionEventsTable = db.BookmarkResumptionEventsTables.Find(id);
            if (bookmarkResumptionEventsTable == null)
            {
                return HttpNotFound();
            }
            return View(bookmarkResumptionEventsTable);
        }

        // POST: BookmarkResumptionEventsTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,WorkflowInstanceId,RecordNumber,TraceLevelId,BookmarkName,BookmarkScope,OwnerActivityName,OwnerActivityId,OwnerActivityInstanceId,OwnerActivityType,SerializedAnnotations,TimeCreated")] BookmarkResumptionEventsTable bookmarkResumptionEventsTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bookmarkResumptionEventsTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bookmarkResumptionEventsTable);
        }

        // GET: BookmarkResumptionEventsTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookmarkResumptionEventsTable bookmarkResumptionEventsTable = db.BookmarkResumptionEventsTables.Find(id);
            if (bookmarkResumptionEventsTable == null)
            {
                return HttpNotFound();
            }
            return View(bookmarkResumptionEventsTable);
        }

        // POST: BookmarkResumptionEventsTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BookmarkResumptionEventsTable bookmarkResumptionEventsTable = db.BookmarkResumptionEventsTables.Find(id);
            db.BookmarkResumptionEventsTables.Remove(bookmarkResumptionEventsTable);
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
