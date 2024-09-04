using DotLearn.DTO;
using DotLearn.Interfaces;
using DotLearn.Repository;
using DotLearn.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DotLearn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _User;
        private readonly JwtTokenService _jwtTokenService;

        public UserController(IUser user, JwtTokenService jwtTokenService)
        {
            _jwtTokenService = jwtTokenService;
            _User = user;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] UserDto userObj)
        {
            try
            {
                if (userObj == null)
                    return BadRequest(userObj);

                // Step 1: Validate the username/password
                var validUser = await _User.ValidateUser(userObj.UserName, userObj.Password);

                if (validUser == null)
                {
                    return Unauthorized("Invalid Login Name or Password");
                }

                // Step 2: Create a token
                var token = _jwtTokenService.GenerateToken(validUser);
                return Ok(new { Token = token });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [Authorize]
        [HttpGet("Get")]
        public IActionResult Get() { return Ok(); }

        [AllowAnonymous]
        [HttpGet("Any")]
        public IActionResult Anonyums()
        {
            return Ok();
        }


        [Authorize(Roles = "Admin")]
        [HttpGet("RBAC")]
        public IActionResult Rbac()
        {

            // Doc @ https://weblog.west-wind.com/posts/2021/Mar/09/Role-based-JWT-Tokens-in-ASPNET-Core
            return Ok();
        }

    }
}
