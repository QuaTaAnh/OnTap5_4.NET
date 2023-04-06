using Microsoft.AspNetCore.Mvc;
using OnTap5_4.Repository;

namespace OnTap5_4.ViewComponents
{
    public class Navbar:ViewComponent
    {
        private readonly ICauLacBo _navbar;
        public Navbar(ICauLacBo navSpRepository)
        {
            _navbar = navSpRepository;
        }
        public IViewComponentResult Invoke()
        {
            var navbar = _navbar.GetAllCauLacBo().OrderBy(x => x.TenClb);
            return View(navbar);
        }
    }
}
