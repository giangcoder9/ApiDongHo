using System.Collections.Generic;
namespace Data.Models
{
    public class ChiTietDatHang
    {
        public string IdCTDH { get; set; }
        public int SoLuong { get; set; }
        public double Gia { get; set; }
        public string IdSP { get; set; }
        public string IdDatHang { get; set; }
        public DatHang DatHang { get; set; }
        public SanPham SanPham { get; set; }
    }
}
