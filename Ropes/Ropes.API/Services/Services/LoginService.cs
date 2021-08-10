using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Ropes.API.Data;
using Ropes.API.Entities.Identity;
using Ropes.API.Exceptions;
using Ropes.API.Services.Services;

namespace Ropes.API.Services
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
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == username);

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
