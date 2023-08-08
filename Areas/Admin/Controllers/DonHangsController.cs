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
    public class DonHangsController : Controller
    {
        private DBShopeeFoodEntities db = new DBShopeeFoodEntities();

        // GET: Admin/DonHangs
        //public ActionResult Index()
        //{
        //    var donHangs = db.DonHangs.Include(d => d.KhachHang).Include(d => d.SanPham);
        //    return View(donHangs.ToList());
        //}

        //// GET: Admin/DonHangs/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    DonHang donHang = db.DonHangs.Find(id);
        //    if (donHang == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(donHang);
        //}

        //// GET: Admin/DonHangs/Create
        //public ActionResult Create()
        //{
        //    ViewBag.MaKH = new SelectList(db.KhachHangs, "MaKhachHang", "TenKhachHang");
        //    ViewBag.MaSP = new SelectList(db.SanPhams, "MaSP", "TenSP");
        //    return View();
        //}

        //// POST: Admin/DonHangs/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "MaDH,MaKH,DiaDiemGiaoHang,NgayDat,NgayGiao,MaSP,TrangThai,TongTien")] DonHang donHang)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.DonHangs.Add(donHang);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.MaKH = new SelectList(db.KhachHangs, "MaKhachHang", "TenKhachHang", donHang.MaKH);
        //    ViewBag.MaSP = new SelectList(db.SanPhams, "MaSP", "TenSP", donHang.MaSP);
        //    return View(donHang);
        //}

        //// GET: Admin/DonHangs/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    DonHang donHang = db.DonHangs.Find(id);
        //    if (donHang == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    ViewBag.MaKH = new SelectList(db.KhachHangs, "MaKhachHang", "TenKhachHang", donHang.MaKH);
        //    ViewBag.MaSP = new SelectList(db.SanPhams, "MaSP", "TenSP", donHang.MaSP);
        //    return View(donHang);
        //}

        //// POST: Admin/DonHangs/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "MaDH,MaKH,DiaDiemGiaoHang,NgayDat,NgayGiao,MaSP,TrangThai,TongTien")] DonHang donHang)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(donHang).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.MaKH = new SelectList(db.KhachHangs, "MaKhachHang", "TenKhachHang", donHang.MaKH);
        //    ViewBag.MaSP = new SelectList(db.SanPhams, "MaSP", "TenSP", donHang.MaSP);
        //    return View(donHang);
        //}

        //// GET: Admin/DonHangs/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    DonHang donHang = db.DonHangs.Find(id);
        //    if (donHang == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(donHang);
        //}

        //// POST: Admin/DonHangs/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    DonHang donHang = db.DonHangs.Find(id);
        //    db.DonHangs.Remove(donHang);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
