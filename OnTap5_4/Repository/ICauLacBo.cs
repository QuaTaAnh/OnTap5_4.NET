using OnTap5_4.Models;
namespace OnTap5_4.Repository
{
	public interface ICauLacBo
	{
		Caulacbo Add(Caulacbo cauLacBo);
		Caulacbo Update(Caulacbo cauLacBo);
		Caulacbo Delete(String idCauLacBo);
		Caulacbo GetCauLacBo(String idCauLacBo);

		IEnumerable<Caulacbo> GetAllCauLacBo();
	}
}
