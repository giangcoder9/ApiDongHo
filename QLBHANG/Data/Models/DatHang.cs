using System.Collections.Generic;

namespace Data.Models
{
    public class DatHang
    {
        public string IdDatHang { get; set; }
        public string NgayDat { get; set; }

        public string HoTen { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaDiem { get; set; }
        public string TongTien { get; set; }
        public ICollection<ChiTietDatHang> ChiTietDatHang { get; set; }
    }
}
