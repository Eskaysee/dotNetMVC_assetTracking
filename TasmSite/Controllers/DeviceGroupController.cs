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
    public class DeviceGroupController : Controller
    {
        private TasmEntities db = new TasmEntities();

        // GET: DeviceGroup
        public ActionResult Index()
        {
            var deviceGroups = db.DeviceGroups.Include(d => d.DeviceGroup2);
            return View(deviceGroups.ToList());
        }

        // GET: DeviceGroup/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeviceGroup deviceGroup = db.DeviceGroups.Find(id);
            if (deviceGroup == null)
            {
                return HttpNotFound();
            }
            return View(deviceGroup);
        }

        // GET: DeviceGroup/Create
        public ActionResult Create()
        {
            ViewBag.ParentGroupId = new SelectList(db.DeviceGroups, "Id", "Name");
            return View();
        }

        // POST: DeviceGroup/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,ParentGroupId")] DeviceGroup deviceGroup)
        {
            if (ModelState.IsValid)
            {
                db.DeviceGroups.Add(deviceGroup);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ParentGroupId = new SelectList(db.DeviceGroups, "Id", "Name", deviceGroup.ParentGroupId);
            return View(deviceGroup);
        }

        // GET: DeviceGroup/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeviceGroup deviceGroup = db.DeviceGroups.Find(id);
            if (deviceGroup == null)
            {
                return HttpNotFound();
            }
            ViewBag.ParentGroupId = new SelectList(db.DeviceGroups, "Id", "Name", deviceGroup.ParentGroupId);
            return View(deviceGroup);
        }

        // POST: DeviceGroup/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,ParentGroupId")] DeviceGroup deviceGroup)
        {
            if (ModelState.IsValid)
            {
                db.Entry(deviceGroup).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ParentGroupId = new SelectList(db.DeviceGroups, "Id", "Name", deviceGroup.ParentGroupId);
            return View(deviceGroup);
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
