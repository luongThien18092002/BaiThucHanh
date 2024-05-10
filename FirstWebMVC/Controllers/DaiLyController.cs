using FirstWebMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebMVC.Controllers
{
    public class DaiLyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(DaiLy ps)
        {
            string strOutput = " Xin Chào " + ps.MaDaiLy + "-" + ps.TenDaiLy + "-" + ps.DiaChi + "-" + ps.NguoiDaiDien + "-" + ps.DienThoai + "-" + ps.MaHTPP;
            ViewBag.infoDaiLy = strOutput;
            return View();
        }
    }
}