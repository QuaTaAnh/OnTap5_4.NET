using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnTap5_4.Models;

public partial class Cauthu
{
    public string CauThuId { get; set; } = null!;

    public string? HoVaTen { get; set; }

    public string? CauLacBoId { get; set; }

    public DateTime? Ngaysinh { get; set; }

    public string? ViTri { get; set; }

    //bat buoc so
    //[RegularExpression(@"^(?:100|[1-9][0-9]|[1-9])$", ErrorMessage = "The value must be between 1 and 100.")]
    [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Quoc tich ban phai nhap chu")] //bat buoc chu
    public string? QuocTich { get; set; }

    public string? SoAo { get; set; }

    [RegularExpression("^.*\\.jpg$", ErrorMessage = "Anh phai co duoi la.jpg .")] //bat buoc anh phai la jpg
    public string? Anh { get; set; }

    public virtual Caulacbo? CauLacBo { get; set; }

    public virtual ICollection<TrandauCauthu> TrandauCauthus { get; } = new List<TrandauCauthu>();

    public virtual ICollection<TrandauGhiban> TrandauGhibans { get; } = new List<TrandauGhiban>();
}
