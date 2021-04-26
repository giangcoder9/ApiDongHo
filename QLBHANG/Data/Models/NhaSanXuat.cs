using System.Collections.Generic;

namespace Data.Models
{
    public class NhaSanXuat
    {
        public string IdNSX { get; set; }
        public string TenNSX { get; set; }
        
        public ICollection<SanPham> SanPham { get; set; }
    }
}
