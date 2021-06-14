using System.Threading.Tasks;
using UBSI_Ops.server.Data;
using UBSI_Ops.server.Entities.Identity;
using UBSI_Ops.server.Exceptions;
using UBSI_Ops.server.Services.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace UBSI_Ops.server.Services
{
    public class LoginService
    {
        private readonly SignInManager<User> _signInManager;
        private readonly OperationContext _context;
        private readonly UserTokenService _tokenService;

        public LoginService(
            SignInManager<User> signInManager,
            OperationContext context,
            UserTokenService tokenService,
            UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _context = context;
            _tokenService = tokenService;
        }

        //public async Task<string> LogIn(string email, string password)
        //{
        //    var user = await _context.Users.FirstOrDefaultAsync(u=>u.Email==email);

        //    if (user is null)
        //    {
        //        throw LoginException.CredentialsMismatch();
        //    }

        //    var userOrganization = await _context
        //        .UserOrganizations
        //        .FirstOrDefaultAsync(t => t.UserId == user.Id);

        //    var result = await _signInManager.PasswordSignInAsync(user, password, false, false);

        //    if (!result.Succeeded)
        //    {
        //        throw LoginException.CredentialsMismatch();
        //    }

        //    var token = _tokenService.CreateAccessToken(user, userOrganization);

        //    return token;
        //}
    }
}
