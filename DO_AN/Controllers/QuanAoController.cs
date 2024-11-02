using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DO_AN.Models;

namespace DO_AN.Controllers
{
    public class QuanAoController : Controller
    {
        //
        // GET: /Sach/
        QuanLyCuaHangQuanAoDataContext db = new QuanLyCuaHangQuanAoDataContext();
        public ActionResult QuanAoPartial()
        {
            var ListFashion = db.SanPhams.ToList();
            return View(ListFashion);
        }   

        public ActionResult ChiTietQuanAoPartial(string id)
        {
            var SanPham = db.SanPhams.FirstOrDefault(s => s.MaSanPham.Trim() == id.Trim());
            if (SanPham == null)
            {
                return HttpNotFound();
            }

            return View(SanPham);
        }

        public ActionResult Index()
        {
            return View();
        }
	}
}