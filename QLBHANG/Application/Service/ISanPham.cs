using AppLication.Generic;
using Data.Models;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Service
{
    public interface ISanPham:IGenericRepository<SanPham>
    {
        List<NhaSanXuatVM> TenSanPhamNhaSanXuat();
        List<TheLoaiSPVM> TenSanPhamTL();
        List<SanPham> SanPhamNoiBat();
        List<SanPham> SanPhamMoi();
        List<SanPham> SanPhamNam();
        List<SanPham> SanPhamNu();
        List<DanhMucSP> DanhMucSP();
        List<SanPham> SanPhamDanhMuc(string Id);
        List<SanPham> SanPhamChiTiet(string Id);
        List<SanPham> SearchSP(string Id);

    }
}
