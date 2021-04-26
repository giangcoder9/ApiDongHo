using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    public class Menu
    {
        public string IdTLSP { get; set; }
        public string TenTL { get; set; }
        public string ParenId { get; set; }
        public string slug { get; set; }
        public List<TheLoaiSP> MenuSub { get; set; }
        public List<NhaSanXuat> TenNSX { get; set; }
    }
}
