using GastroManagerBE.DB;
using GastroManagerBE.HttpRequest;
using GastroManagerBE.Interfaces;
using GastroManagerBE.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GastroManagerBE.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("Policy")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userService;
        private readonly IConfiguration Configuration;
        private readonly GastroManagerContext _context;

        public UserController(IUserServices userService, IConfiguration configuration, GastroManagerContext context)
        {
            _userService = userService;
            Configuration = configuration;
            _context = context;
        }

        [HttpPost("[Action]")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            try
            {
                if (string.IsNullOrEmpty(request.username) || string.IsNullOrEmpty(request.password))
                    return new BadRequestObjectResult(new { success = false, data = "El usuario y/o contraseña estan vacios" });

                var user = _context.Users.Where(x => x.Username == request.username).FirstOrDefault();
                if (user == null)
                    return new BadRequestObjectResult(new { success = false, data = "El usuario no se encuentra registrado" });

                var response = new
                {
                    success = true,
                    data = user,
                };
                return new OkObjectResult(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    success = false,
                    error = ex.Message,
                    errorCode = ex.HResult
                };
                return new BadRequestObjectResult(response);
            }
        }

        [HttpPost("[Action]")]
        public async Task<IActionResult> Registro([FromBody] UserCreateRequest request)
        {
            try
            {

                var newUser = new User()
                {
                    Email = request.email,
                    Username = request.username,
                    Password = request.password,
                    Role = "User",
                    CreatedBy = "API",
                    CreatedAt = DateTime.Now
                };

                await _userService.AddAsync(newUser);

                var response = new
                {
                    success = true,
                    data = newUser,
                };
                return new OkObjectResult(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    success = false,
                    error = ex.Message,
                    errorCode = ex.HResult
                };
                return new BadRequestObjectResult(response);
            }
        }

    }
}
