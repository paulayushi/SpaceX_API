using Microsoft.AspNetCore.Mvc;
using SpaceX.Models.DTO.User;
using SpaceX.Services;

namespace SpaceX.WebAPI.Controllers
{
    [ApiController]
    [Route("spacex/api/auth/")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authSvc;
        public AuthController(IAuthService authSvc)
        {
            _authSvc = authSvc;
        }

        [HttpPost]
        [Route("login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Login([FromBody] UserLogin userLogin)
        {
            var user = await _authSvc.AuthenticateAsync(userLogin);
            if (user != null)
            {
                var token = await _authSvc.GenerateToken(user);
                return Ok(token);
            }

            return Unauthorized("User not found");
        }              
    }
}
