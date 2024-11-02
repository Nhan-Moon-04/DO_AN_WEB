using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DO_AN.Models;

namespace DO_AN.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        QuanLyCuaHangQuanAoDataContext db = new QuanLyCuaHangQuanAoDataContext();

        public ActionResult Index()
        {
            var SanPham = db.SanPhams.ToList();
            return View(SanPham);
        }
        public ActionResult ChinhSachDoiTra()
        {
           
            return View();
        }
	}
}