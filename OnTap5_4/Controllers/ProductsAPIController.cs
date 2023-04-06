using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnTap5_4.Models;
using OnTap5_4.Models.ProductModels;

namespace WebNo3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsAPIController : ControllerBase
    {
        QlbongDaContext db = new QlbongDaContext();
        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            var products = (from a in db.Caulacbos
                            join b in db.Cauthus on a.CauLacBoId equals b.CauLacBoId select new Product
                            {
                                IdCauLacBo = a.CauLacBoId,
                                TenCauLacBo = a.TenClb,
                                TenCauThu = b.HoVaTen,
                                AnhCauThu = b.Anh,
                                QuocGia = b.QuocTich,
                            }).ToList();
            return products;
        }

        [HttpGet("{CauLacBoId}")]
        public IEnumerable<Product> GetProductsByCategory(string CauLacBoId)
        {
			var products = (from a in db.Caulacbos
							join b in db.Cauthus on a.CauLacBoId equals b.CauLacBoId
                            where a.CauLacBoId == CauLacBoId
							select new Product
							{
								IdCauLacBo = a.CauLacBoId,
								TenCauLacBo = a.TenClb,
								TenCauThu = b.HoVaTen,
								AnhCauThu = b.Anh,
								QuocGia = b.QuocTich,
							}).ToList();
			return products;
		}
    }
}
