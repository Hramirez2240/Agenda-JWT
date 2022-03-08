using Agenda_Crud_JWT.Model.Context;
using Agenda_Crud_JWT.Model.Entities;
using Agenda_Crud_JWT.Services;
using Agenda_Crud_JWT.Services.JWT;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda_Crud_JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IJWTAuthenticationManager _iJWTAuthenticationManager;
        private readonly IApplicationDbContext _applicationDbContext;

        public LoginController(IJWTAuthenticationManager iJWTAuthenticationManager, IApplicationDbContext applicationDbContext)
        {
            _iJWTAuthenticationManager = iJWTAuthenticationManager;
            _applicationDbContext = applicationDbContext;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Authenticate([FromBody] Login login)
        {
            var session_id = _applicationDbContext.GetDbSet<User>()
                .Where(x => x.Email == login.Email)
                .Select(x => x.Id).FirstOrDefault();

            var token = _iJWTAuthenticationManager.Authenticate(session_id, login.Email, login.Password);

            if (token is null) { return Unauthorized(); }

            return Ok(token);
        }

        [Authorize]
        [HttpGet]
        public string Prueba()
        {
            var id = User.Identity.Name;

            return id;
        }
    }
}
