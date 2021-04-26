using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppLication.UOW;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhaSanXuatController : ControllerBase
    {
        private IUnitOfWork unitOfWork;
        private IHostingEnvironment _environment;
        public NhaSanXuatController(IUnitOfWork _unitOfWork, IHostingEnvironment _environment)
        {
            this._environment = _environment;
            unitOfWork = _unitOfWork;
        }
        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            return Ok(unitOfWork.NSX.GetAll());
        }

        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById(string Id)
        {
            return Ok(unitOfWork.NSX.SPTheoNSX(Id));
        }
    }
}
