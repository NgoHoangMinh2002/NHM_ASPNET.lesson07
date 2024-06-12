using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NhmK22CNT3Lss07.Models;

namespace NhmK22CNT3Lss07.Controllers
{
    public class nhmsinhvien4Controller : Controller
    {
        private NhmK22CNTT3Lesson7Entities db = new NhmK22CNTT3Lesson7Entities();

        // GET: nhmsinhvien4
        public ActionResult NhmIndex()
        {
            var nhmsinhvien4 = db.nhmsinhvien4.Include(n => n.NhmKhoa);
            return View(nhmsinhvien4.ToList());
        }

        // GET: nhmsinhvien4/Details/5
        public ActionResult NhmDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nhmsinhvien4 nhmsinhvien4 = db.nhmsinhvien4.Find(id);
            if (nhmsinhvien4 == null)
            {
                return HttpNotFound();
            }
            return View(nhmsinhvien4);
        }

        // GET: nhmsinhvien4/Create
        public ActionResult NhmCreate()
        {
            ViewBag.NhmMaKH = new SelectList(db.NhmKhoas, "NhmMaKH", "NhmTenKH");
            return View();
        }

        // POST: nhmsinhvien4/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NhmCreate([Bind(Include = "NhmMaSV,NhmHoSV,NhmTenSV,NhmNgaySinh,NhmPhai,NhmPhone,NhmEmail,NhmMaKH")] nhmsinhvien4 nhmsinhvien4)
        {
            if (ModelState.IsValid)
            {
                db.nhmsinhvien4.Add(nhmsinhvien4);
                db.SaveChanges();
                return RedirectToAction("NhmIndex");
            }

            ViewBag.NhmMaKH = new SelectList(db.NhmKhoas, "NhmMaKH", "NhmTenKH", nhmsinhvien4.NhmMaKH);
            return View(nhmsinhvien4);
        }

        // GET: nhmsinhvien4/Edit/5
        public ActionResult NhmEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nhmsinhvien4 nhmsinhvien4 = db.nhmsinhvien4.Find(id);
            if (nhmsinhvien4 == null)
            {
                return HttpNotFound();
            }
            ViewBag.NhmMaKH = new SelectList(db.NhmKhoas, "NhmMaKH", "NhmTenKH", nhmsinhvien4.NhmMaKH);
            return View(nhmsinhvien4);
        }

        // POST: nhmsinhvien4/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NhmEdit([Bind(Include = "NhmMaSV,NhmHoSV,NhmTenSV,NhmNgaySinh,NhmPhai,NhmPhone,NhmEmail,NhmMaKH")] nhmsinhvien4 nhmsinhvien4)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhmsinhvien4).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NhmIndex");
            }
            ViewBag.NhmMaKH = new SelectList(db.NhmKhoas, "NhmMaKH", "NhmTenKH", nhmsinhvien4.NhmMaKH);
            return View(nhmsinhvien4);
        }

        // GET: nhmsinhvien4/Delete/5
        public ActionResult NhmDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nhmsinhvien4 nhmsinhvien4 = db.nhmsinhvien4.Find(id);
            if (nhmsinhvien4 == null)
            {
                return HttpNotFound();
            }
            return View(nhmsinhvien4);
        }

        // POST: nhmsinhvien4/Delete/5
        [HttpPost, ActionName("NhmDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            nhmsinhvien4 nhmsinhvien4 = db.nhmsinhvien4.Find(id);
            db.nhmsinhvien4.Remove(nhmsinhvien4);
            db.SaveChanges();
            return RedirectToAction("NhmIndex");
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
