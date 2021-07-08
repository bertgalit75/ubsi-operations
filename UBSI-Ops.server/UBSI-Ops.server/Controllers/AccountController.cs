﻿using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UBSI_Ops.server.Exceptions;
using UBSI_Ops.server.Models.Request;
using UBSI_Ops.server.Services;

namespace UBSI_Ops.server.Controllers
{
    [Route("api/account")]
    [ApiController]
    [Produces("application/json")]

    public class AccountController : ControllerBase
    {
        private readonly LoginService _loginService;
        public AccountController(LoginService loginService)
        {
            _loginService = loginService;
        }

        /// <summary>
        /// User Authentication
        /// </summary>
        /// <returns></returns>
        [HttpPost("login")]
        public async Task<ActionResult<LoginResult>> login([FromBody] LoginModel model)
        {
            try
            {
                var token = await _loginService.LogIn(model.Username, model.Password);

                return new LoginResult { Token = token };
            }
            catch (LoginException ex)
            {
                return BadRequest(new { ErrorType = ex.Message });
            }
        }

        public class LoginResult
        {
            public string Token { get; set; }
        }

    }
}
