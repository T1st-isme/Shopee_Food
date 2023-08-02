using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Shopee_Food.Models;
using Shopee_Food.Areas.Admin.map;

namespace Shopee_Food.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        private DBShopeeFoodEntities db = new DBShopeeFoodEntities();

        // GET: Admin/Users
        public ActionResult Index()
        {
            var users = db.Users.Include(u => u.ChucVu);
            return View(users.ToList());
        }

        // GET: Admin/Users/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: Admin/Users/Create
        public ActionResult Create()
        {
            ViewBag.MaCV = new SelectList(db.ChucVus, "MaCV", "TenCV");
            return View();
        }

        // POST: Admin/Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaTK,TaiKhoan,MatKhau,HoTen,DiaChi,SDT,Email,GioiTinh,MaCV")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaCV = new SelectList(db.ChucVus, "MaCV", "TenCV", user.MaCV);
            return View(user);
        }

        // GET: Admin/Users/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaCV = new SelectList(db.ChucVus, "MaCV", "TenCV", user.MaCV);
            return View(user);
        }

        // POST: Admin/Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaTK,TaiKhoan,MatKhau,HoTen,DiaChi,SDT,Email,GioiTinh,MaCV")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaCV = new SelectList(db.ChucVus, "MaCV", "TenCV", user.MaCV);
            return View(user);
        }

        // GET: Admin/Users/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Admin/Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string taiKhoan, string passWord)
        {
            //Check tai khoan va mat khau isEmpty() => return LoginPage
            if (string.IsNullOrEmpty(taiKhoan) || string.IsNullOrEmpty(passWord))
            {
                ViewBag.Error = "Tài khoản và mật khẩu không được trống";
                return View();
            }

            //find tai khoan trong db
            var mapTaiKhoan = new mapTaiKhoan().ChiTiet(taiKhoan);

            //check tai khoan co ton tai hay khong
            if (mapTaiKhoan == null)
            {
                ViewBag.Error = "Tài khoản không tồn tại";
                ViewBag.TaiKhoan = taiKhoan;
                return View();
            }

            //check mat khau co dung hay khong
            if (mapTaiKhoan.MatKhau != passWord)
            {
                ViewBag.Error = "Mật khẩu không đúng";
                ViewBag.TaiKhoan = taiKhoan;
                return View();
            }

            ////check tai khoan co phai la admin hay khong
            //if (mapTaiKhoan.MaCV != 1)
            //{
            //    ViewBag.Error = "Tài khoản không phải là admin";
            //    ViewBag.TaiKhoan = taiKhoan;
            //    return View();
            //}

            //set session
            Session["user"] = mapTaiKhoan;

            return Redirect("/Admin/AdHome");
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