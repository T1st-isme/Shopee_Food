﻿using System;
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
    public class ShopsController : Controller
    {
        private DBShopeeFoodEntities db = new DBShopeeFoodEntities();

        // GET: Admin/Shop
        public ActionResult Index()
        {
            var shops = db.Shop.Include(s => s.Users);
            return View(shops.ToList());
        }

        // GET: Admin/Shop/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shop shop = db.Shop.Find(id);
            if (shop == null)
            {
                return HttpNotFound();
            }
            return View(shop);
        }

        // GET: Admin/Shop/Create
        public ActionResult Create()
        {
            ViewBag.MaTK = new SelectList(db.User, "MaTK", "TaiKhoan");
            return View();
        }

        // POST: Admin/Shop/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaShop,TenShop,DanhGia,TinhTrang,SoLuongSanPham,DoanhThu,AnhBia,AnhDaiDien,AnhThucTe,MaTK")] Shop shop)
        {
            if (ModelState.IsValid)
            {
                db.Shop.Add(shop);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaTK = new SelectList(db.User, "MaTK", "TaiKhoan", shop.MaTK);
            return View(shop);
        }

        // GET: Admin/Shop/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shop shop = db.Shop.Find(id);
            if (shop == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaTK = new SelectList(db.User, "MaTK", "TaiKhoan", shop.MaTK);
            return View(shop);
        }

        // POST: Admin/Shop/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaShop,TenShop,DanhGia,TinhTrang,SoLuongSanPham,DoanhThu,AnhBia,AnhDaiDien,AnhThucTe,MaTK")] Shop shop)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shop).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaTK = new SelectList(db.User, "MaTK", "TaiKhoan", shop.MaTK);
            return View(shop);
        }

        // GET: Admin/Shop/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shop shop = db.Shop.Find(id);
            if (shop == null)
            {
                return HttpNotFound();
            }
            return View(shop);
        }

        // POST: Admin/Shop/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Shop shop = db.Shop.Find(id);
            db.Shop.Remove(shop);
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