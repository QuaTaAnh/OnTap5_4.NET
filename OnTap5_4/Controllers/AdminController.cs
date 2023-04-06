using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnTap5_4.Models;

namespace OnTap5_4.Controllers
{
	public class AdminController : Controller
	{
        QlbongDaContext db = new QlbongDaContext();
        [Route("/admin")]
        public IActionResult Index()
		{
			return View();
		}
        //Thêm mới sản phẩm
        [Route("ThemSanPham")]
        [HttpGet]
        public IActionResult ThemSanPham()
        {
            ViewBag.CauLacBoId = new SelectList(db.Caulacbos.ToList(),
                "CauLacBoId", "TenClb");
            return View();
        }

        [Route("ThemSanPham")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult themSanPham(Cauthu sanpham)
        {
            if (ModelState.IsValid)
            {
                db.Cauthus.Add(sanpham);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sanpham);
        }
    }
}
