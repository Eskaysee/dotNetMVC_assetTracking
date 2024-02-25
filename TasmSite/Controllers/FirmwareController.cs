using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TasmSite.Models;

namespace TasmSite.Controllers
{
    public class FirmwareController : Controller
    {
        private TasmEntities db = new TasmEntities();

        // GET: Firmware
        public ActionResult Index()
        {
            return View(db.Firmwares.ToList());
        }

        // GET: Firmware/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Firmware firmware = db.Firmwares.Find(id);
            if (firmware == null)
            {
                return HttpNotFound();
            }
            return View(firmware);
        }

        // GET: Firmware/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Firmware/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Version,ReleaseDate")] Firmware firmware)
        {
            if (ModelState.IsValid)
            {
                db.Firmwares.Add(firmware);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(firmware);
        }

        // GET: Firmware/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Firmware firmware = db.Firmwares.Find(id);
            if (firmware == null)
            {
                return HttpNotFound();
            }
            return View(firmware);
        }

        // POST: Firmware/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Version,ReleaseDate")] Firmware firmware)
        {
            if (ModelState.IsValid)
            {
                db.Entry(firmware).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(firmware);
        }

        // GET: Firmware/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Firmware firmware = db.Firmwares.Find(id);
            if (firmware == null)
            {
                return HttpNotFound();
            }
            return View(firmware);
        }

        // POST: Firmware/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Firmware firmware = db.Firmwares.Find(id);
            db.Firmwares.Remove(firmware);
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
