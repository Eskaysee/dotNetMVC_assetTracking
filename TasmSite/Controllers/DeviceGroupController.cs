using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using TasmSite.Models;

namespace TasmSite.Controllers
{
    /// <summary>
    /// Handles the User input from the view, handles request and makes changes to the DeviceGroup model
    /// </summary>
    public class DeviceGroupController : Controller
    {
        private TasmEntities db = new TasmEntities();

        // GET: DeviceGroup
        public ActionResult Index()
        {
            var deviceGroups = db.DeviceGroups.Include(d => d.DeviceGroup2);
            return View(deviceGroups.ToList());
        }

        /// <summary>
        /// retrieves the details of the DeviceGroup of the specified id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Details view for the DeviceGroup of the specified id</returns>
        // HTTP GET request: DeviceGroup/Details/{id}
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
