using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Shopee_Food.Models;

namespace Shopee_Food.Controllers
{
    public class Users_newController : Controller
    {
        private DBShopeeFoodEntities db = new DBShopeeFoodEntities();

        {
        }

        {
            {
        }
                else
                {
                    ViewBag.ErrorRegister = "This ID is exist";
                    return View();
                }
            }
            ViewBag.MaCV = new SelectList(db.ChucVus, "MaCV", "TenCV");
            return View();
        }

        {
        }

    {
        // GET: Users_new
        public ActionResult Index()
        {
            var users = db.Users.Include(u => u.ChucVu);
            return View(users.ToList());
        }

        // GET: Users_new/Details/5
>>>>>>>> 966b004938c3f8981e5f462f76d02a2325c5ce16:Controllers/Users_newController.cs
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            {
                return HttpNotFound();
            }
        }

<<<<<<<< HEAD:Controllers/Shops_newController.cs
        // GET: Shops_new/Create
========
        // GET: Users_new/Create
>>>>>>>> 966b004938c3f8981e5f462f76d02a2325c5ce16:Controllers/Users_newController.cs
        public ActionResult Create()
        {
            ViewBag.MaCV = new SelectList(db.ChucVus, "MaCV", "TenCV");
            return View();
        }

<<<<<<<< HEAD:Controllers/Shops_newController.cs
        // POST: Shops_new/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaShop,TenShop,DanhGia,TinhTrang,SoLuongSanPham,DoanhThu,AnhBia,AnhDaiDien,AnhThucTe,MaTK,MoTa,HinhMenu")] Shop shop)
========
        // POST: Users_new/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        {
            if (ModelState.IsValid)
            {
                db.SaveChanges();
            }
        }

<<<<<<<< HEAD:Controllers/Shops_newController.cs
        // GET: Shops_new/Edit/5
========
        // GET: Users_new/Edit/5
>>>>>>>> 966b004938c3f8981e5f462f76d02a2325c5ce16:Controllers/Users_newController.cs
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            {
                return HttpNotFound();
            }
        }

        // POST: Users_new/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        {
            if (ModelState.IsValid)
            {
                db.SaveChanges();
            }
        }

<<<<<<<< HEAD:Controllers/Shops_newController.cs
        // GET: Shops_new/Delete/5
========
        // GET: Users_new/Delete/5
>>>>>>>> 966b004938c3f8981e5f462f76d02a2325c5ce16:Controllers/Users_newController.cs
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            {
                return HttpNotFound();
            }
        }

<<<<<<<< HEAD:Controllers/Shops_newController.cs
        // POST: Shops_new/Delete/5
========
        // POST: Users_new/Delete/5
>>>>>>>> 966b004938c3f8981e5f462f76d02a2325c5ce16:Controllers/Users_newController.cs
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
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