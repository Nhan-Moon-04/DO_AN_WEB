using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DO_AN.Models;

namespace DO_AN.Controllers
{
    public class LoaiQuanAoController : Controller
    {
        //
        // GET: /ChuDe/
        QuanLyCuaHangQuanAoDataContext db = new QuanLyCuaHangQuanAoDataContext();
        public ActionResult LoaiQuanAoPartial()
        {
            var ListQuanAo = db.LoaiSanPhams.OrderBy(cd => cd.TenLoai).ToList();
            return View(ListQuanAo);
        }
        //public ActionResult NhaSanXuatPartial()
        //{
        //    var ListNSX = db.NhaXuatBans.Take(7).OrderBy(cd => cd.TenNXB).ToList();
        //    return View(ListNSX);
        //}
        //public ActionResult SachTheoChuDePartial(int MaCD)
        //{
        //    var ListSach = db.Saches.Where(s => s.MaChuDe == MaCD).ToList();
        //    if (ListSach.Count == 0)
        //    {
        //        ViewBag.TB = "Khong co sach thuoc chu de nay";
        //    }
        //    return View(ListSach);
        //}
        //public ActionResult SachTheoNXBPartial(int MaNXB)
        //{
        //    var ListSachNXB = db.Saches.Where(s => s.MaChuDe == MaNXB).ToList();
        //    if (ListSachNXB.Count == 0)
        //    {
        //        ViewBag.TB = "Khong co sach thuoc nha xuat ban nay";
        //    }
        //    return View(ListSachNXB);
        //}
        public ActionResult Index()
        {
            return View();
        }
    }
}