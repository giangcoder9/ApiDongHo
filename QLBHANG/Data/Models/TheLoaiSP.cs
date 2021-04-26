using System.Collections.Generic;

namespace Data.Models
{
    public class TheLoaiSP
    {
        public string IdTLSP { get; set; }
        public string TenLoaiSP { get; set; }
        public string ParenId { get; set; }
        public string slug { get; set; }
        public ICollection<SanPham> SanPham { get; set; }
    }
}
