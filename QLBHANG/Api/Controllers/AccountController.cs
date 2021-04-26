using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AppLication.UOW;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly IConfiguration configuration;
        
        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IConfiguration configuration) {
           
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.configuration = configuration;
        }
        [HttpPost]
        [Route("PostDangKy")]
        public async Task<IActionResult> PostDangKy(RegisterVM model)
        {
            
            
                
                var user = new IdentityUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                };

            try
            {
                var result = await userManager.CreateAsync(user, model.Password);
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw ex;
                return Ok(ModelState);
            }

        }
        


        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginViewModel model)
        {
            var user = await userManager.FindByNameAsync(model.Email);

            if (user != null && await userManager.CheckPasswordAsync(user, model.Password))
            {
                var userRoles = await userManager.GetRolesAsync(user);
                var authCliam = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name,user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                    new Claim("name",user.UserName)
                };
                var roles = await userManager.GetRolesAsync(user);
                foreach (var userRole in roles)
                {
                    authCliam.Add(new Claim(ClaimTypes.Role, userRole));
                }

                var AuthSiginKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwT:Secret"]));
                var token = new JwtSecurityToken(
                    issuer: configuration["JWT:ValidIssuer"],
                    audience: configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddHours(5),
                    claims: authCliam,
                    signingCredentials: new SigningCredentials(AuthSiginKey, SecurityAlgorithms.HmacSha256)
                    
                    );
                return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) ,user});
            }
            if(user==null)
            {
                return Ok("Tài Khoản Chưa Tồn Tại");
            }
            if (!await userManager.CheckPasswordAsync(user, model.Password))
            {
                return Ok("Sai Mật Khẩu");
            }
            return Unauthorized();
        }
    }
}
