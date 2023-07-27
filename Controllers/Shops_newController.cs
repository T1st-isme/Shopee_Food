using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Shopee_Food.Models;

namespace Shopee_Food.Controllers
{
<<<<<<<< HEAD:Controllers/Shops_newController.cs
    public class Shops_newController : Controller
    {
        private DBShopeeFoodEntities db = new DBShopeeFoodEntities();

        public ActionResult dangki()
        {
            return View();
        }

        public ActionResult all()
        {
            // Lấy danh sách cửa hàng từ bảng Shop và kết hợp với thông tin từ bảng Users
            //var shopUsers = from shop in db.Shop
            //                    join user in db.Users on shop.MaTK equals user.MaTK
            //                    select new ShopUserModel
            //                    {
            //                        Email = user.Email,
            //                        TenShop = shop.TenShop,
            //                        TinhTrang = shop.TinhTrang,
            //                        AnhBia = shop.AnhBia,
            //                        AnhDaiDien = shop.AnhDaiDien,
            //                        AnhThucTe = shop.AnhThucTe,
            //                        MaTK = user.MaTK,
            //                        HoTen = user.HoTen,
            //                        DiaChi = user.DiaChi,
            //                        SDT = user.SDT,
            //                        CCCD = user.CCCD,
            //                        MoTa = shop.MoTa
            //                    };
            //    return View(shopUsers.ToList());

            List<User> users = db.Users.ToList();

            // Lấy danh sách Shop từ bảng Shop
            List<Shop> shops = db.Shops.ToList();

            //string currentUserUsername = User.Identity.Name;
            //Users currentUser = db.Users.FirstOrDefault(u => u.TaiKhoan == currentUserUsername);

            //if (currentUser == null)
            //{
            //    // Xử lý khi không tìm thấy thông tin người dùng đăng nhập
            //    return RedirectToAction("Login", "Account"); // Chuyển hướng đến trang đăng nhập nếu không tìm thấy thông tin người dùng
            //}

            var viewModel = new ShopUserModel
            {
                Users = users,
                Shops = shops
            };

            return View(viewModel);
        }

        // GET: Shops_new
        public ActionResult Index()
        {
            var shop = db.Shops.Include(s => s.User);
            return View(shop.ToList());
        }

        // GET: Shops_new/Details/5
========
    public class Users_newController : Controller
    {
        private DBShopeeFoodEntities db = new DBShopeeFoodEntities();

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
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
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
        public ActionResult Create([Bind(Include = "MaTK,TaiKhoan,MatKhau,HoTen,DiaChi,SDT,Email,GioiTinh,MaCV")] User user)
>>>>>>>> 966b004938c3f8981e5f462f76d02a2325c5ce16:Controllers/Users_newController.cs
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Edit", new { id = shop.MaShop });
            }

            ViewBag.MaCV = new SelectList(db.ChucVus, "MaCV", "TenCV", user.MaCV);
            return View(user);
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
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
<<<<<<<< HEAD:Controllers/Shops_newController.cs
            ViewBag.MaTK = new SelectList(db.Users, "MaTK", "TaiKhoan", shop.MaTK);

            return View(shop);
        }

        // POST: Shops_new/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaShop,TenShop,DanhGia,TinhTrang,SoLuongSanPham,DoanhThu,AnhBia,AnhDaiDien,AnhThucTe,MaTK,MoTa,HinhMenu")] Shop shop)
========
            ViewBag.MaCV = new SelectList(db.ChucVus, "MaCV", "TenCV", user.MaCV);
            return View(user);
        }

        // POST: Users_new/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaTK,TaiKhoan,MatKhau,HoTen,DiaChi,SDT,Email,GioiTinh,MaCV")] User user)
>>>>>>>> 966b004938c3f8981e5f462f76d02a2325c5ce16:Controllers/Users_newController.cs
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Edit", "Users_new", new { id = shop.MaTK });
            }
            ViewBag.MaCV = new SelectList(db.ChucVus, "MaCV", "TenCV", user.MaCV);
            return View(user);
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
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
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
            User user = db.Users.Find(id);
            db.Users.Remove(user);
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