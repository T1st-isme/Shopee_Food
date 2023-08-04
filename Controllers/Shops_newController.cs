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
    public class Shops_newController : Controller
    {
        private DBShopeeFoodEntities db = new DBShopeeFoodEntities();

        public ActionResult dangki()
        {
            return View();
        }

        public ActionResult UserDetails(int? MaTK)
        {
            User user = db.Users.FirstOrDefault(u => u.MaTK == MaTK);
            Shop shop = db.Shops.FirstOrDefault(s => s.MaTK == MaTK);
            var viewModel = new ShopUserModel
            {
                User = user,
                Shop = shop
            };
            return View(viewModel);
        }

        /// <summary>
        /// ///////////
        /// </summary>
        /// <returns></returns>

        // GET: Shops_new
        public ActionResult Index()
        {
            var shop = db.Shops.Include(s => s.User);
            return View(shop.ToList());
        }

        // GET: Shops_new/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shop shop = db.Shops.Find(id);
            if (shop == null)
            {
                return HttpNotFound();
            }
            return View(shop);
        }

        // GET: Shops_new/Create
        public ActionResult Create()
        {
            ViewBag.MaTK = new SelectList(db.Users, "MaTK", "TaiKhoan");
            return View();
        }

        // POST: Shops_new/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaShop,TenShop,DanhGia,TinhTrang,SoLuongSanPham,DoanhThu,AnhBia,AnhDaiDien,AnhThucTe,MaTK,MoTa,HinhMenu")] Shop shop)
        {
            if (ModelState.IsValid)
            {
                db.Shops.Add(shop);
                db.SaveChanges();
                return RedirectToAction("Edit", new { id = shop.MaShop });
            }

            ViewBag.MaTK = new SelectList(db.Users, "MaTK", "TaiKhoan", shop.MaTK);
            return View(shop);
        }

        // GET: Shops_new/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shop shop = db.Shops.Find(id);
            if (shop == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaTK = new SelectList(db.Users, "MaTK", "TaiKhoan", shop.MaTK);

            return View(shop);
        }

        // POST: Shops_new/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaShop,TenShop,DanhGia,TinhTrang,SoLuongSanPham,DoanhThu,AnhBia,AnhDaiDien,AnhThucTe,MaTK,MoTa,HinhMenu")] Shop shop)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shop).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Edit", "Users_new", new { id = shop.MaTK });
            }
            ViewBag.MaTK = new SelectList(db.Users, "MaTK", "TaiKhoan", shop.MaTK);
            return View(shop);
        }

        // GET: Shops_new/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shop shop = db.Shops.Find(id);
            if (shop == null)
            {
                return HttpNotFound();
            }
            return View(shop);
        }

        // POST: Shops_new/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Shop shop = db.Shops.Find(id);
            db.Shops.Remove(shop);
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