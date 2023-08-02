using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Shopee_Food.Models;

namespace Shopee_Food.Areas.Admin.Controllers
{
    public class ChucVuController : Controller
    {
        private DBShopeeFoodEntities db = new DBShopeeFoodEntities();

        // GET: Admin/ChucVu
        public ActionResult Index()
        {
            return View(db.ChucVu.ToList());
        }

        // GET: Admin/ChucVu/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChucVu chucVu = db.ChucVu.Find(id);
            if (chucVu == null)
            {
                return HttpNotFound();
            }
            return View(chucVu);
        }

        // GET: Admin/ChucVu/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/ChucVu/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaCV,TenCV")] ChucVu chucVu)
        {
            if (ModelState.IsValid)
            {
                db.ChucVu.Add(chucVu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(chucVu);
        }

        // GET: Admin/ChucVu/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChucVu chucVu = db.ChucVu.Find(id);
            if (chucVu == null)
            {
                return HttpNotFound();
            }
            return View(chucVu);
        }

        // POST: Admin/ChucVu/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaCV,TenCV")] ChucVu chucVu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chucVu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(chucVu);
        }

        // GET: Admin/ChucVu/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChucVu chucVu = db.ChucVu.Find(id);
            if (chucVu == null)
            {
                return HttpNotFound();
            }
            return View(chucVu);
        }

        // POST: Admin/ChucVu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ChucVu chucVu = db.ChucVu.Find(id);
            db.ChucVu.Remove(chucVu);
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