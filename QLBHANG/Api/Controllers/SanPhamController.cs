using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Application.Service;
using AppLication.UOW;
using Data.Models;
using Data.ViewModel;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class SanPhamController : ControllerBase
    {
        private IUnitOfWork unitOfWork;
        private IHostingEnvironment _environment;
        public SanPhamController(IUnitOfWork _unitOfWork, IHostingEnvironment _environment)
        {
            this._environment = _environment;
            unitOfWork = _unitOfWork;
        }
        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            return Ok(unitOfWork.SanPhams.GetAll());
        }
        [HttpGet]
        [Route("GetTheoNSX")]
        public IActionResult GetNSX()
        {
            return Ok(unitOfWork.SanPhams.TenSanPhamNhaSanXuat());
        }

        [HttpGet]
        [Route("GetTheoTL")]
        public IActionResult GetTL()
        {
            return Ok(unitOfWork.SanPhams.TenSanPhamTL());
        }


        [HttpGet]
        [Route("GetSPNoiBat")]
        public IActionResult GetSPNoiBat()
        {
            return Ok(unitOfWork.SanPhams.SanPhamNoiBat());
        }

        [HttpGet]
        [Route("GetSPMoi")]
        public IActionResult GetSPMoi()
        {
            return Ok(unitOfWork.SanPhams.SanPhamMoi());
        }

        [HttpGet]
        [Route("GetSPNam")]
        public IActionResult GetSPNam()
        {
            return Ok(unitOfWork.SanPhams.SanPhamNam());
        }

        [HttpGet]
        [Route("GetSPNu")]
        public IActionResult GetSPNu()
        {
            return Ok(unitOfWork.SanPhams.SanPhamNu());
        }

        [HttpGet]
        [Route("GetDanhMucSP")]
        public IActionResult GetDanhMucSP()
        {
            return Ok(unitOfWork.SanPhams.DanhMucSP());
        }

        [HttpGet]
        [Route("GetChiTiet/{Id}")]
        public IActionResult GetChiTiet(string Id)
        {
            return Ok(unitOfWork.SanPhams.SanPhamChiTiet(Id));
        }

        [HttpGet]
        [Route("SearchSP/{Id}")]
        public IActionResult SearchSP(string Id)
        {
            return Ok(unitOfWork.SanPhams.SearchSP(Id));
        }

    }
}
