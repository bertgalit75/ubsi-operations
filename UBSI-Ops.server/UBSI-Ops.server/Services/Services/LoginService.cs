using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using UBSI_Ops.server.Data;
using UBSI_Ops.server.Entities.Identity;
using UBSI_Ops.server.Exceptions;
using UBSI_Ops.server.Services.Services;

namespace UBSI_Ops.server.Services
{
    public class LoginService
    {
        private readonly SignInManager<User> _signInManager;
        private readonly OperationContext _context;
        private readonly UserTokenService _tokenService;
        private readonly UserManager<User> _userManager;

        public LoginService(
            SignInManager<User> signInManager,
            OperationContext context,
            UserTokenService tokenService,
            UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _context = context;
            _tokenService = tokenService;
            _userManager = userManager;
        }

        public async Task<string> LogIn(string username, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == username);

            if (user is null)
            {
                throw LoginException.CredentialsMismatch();
            }


            var result = await _userManager.CheckPasswordAsync(user, password);

            if (!result)
            {
                throw LoginException.CredentialsMismatch();
            }

            var token = _tokenService.CreateAccessToken(user);

            return token;
        }
    }
}
