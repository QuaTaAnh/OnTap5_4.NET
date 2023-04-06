using OnTap5_4.Models;

namespace OnTap5_4.Repository
{
	public class CCauLacBo : ICauLacBo
	{
		private readonly QlbongDaContext _context;
		public CCauLacBo(QlbongDaContext context)
		{
			_context = context;
		}
		public Caulacbo Add(Caulacbo cauLacBo)
		{
			_context.Caulacbos.Add(cauLacBo);
			_context.SaveChanges();
			return cauLacBo;
		}

		public Caulacbo Delete(string idCauLacBo)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Caulacbo> GetAllCauLacBo()
		{
			return _context.Caulacbos;
		}

		public Caulacbo GetCauLacBo(string idCauLacBo)
		{
			return _context.Caulacbos.Find(idCauLacBo);
		}

		public Caulacbo Update(Caulacbo cauLacBo)
		{
			_context.Update(cauLacBo);
			_context.SaveChanges();
			return cauLacBo;
		}
	}
}
