using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;
using UBSI_Ops.server.Entities.Identity;

namespace UBSI_Ops.server.Services.Validator
{
    public class CustomPasswordValidator<TUser> : IPasswordValidator<User>
        where TUser : class
    {
        public Task<IdentityResult> ValidateAsync(UserManager<User> manager, User user, string password)
        {
            var MinLength = 8;
            int i;

            if (string.Equals(user.UserId, password, StringComparison.OrdinalIgnoreCase))
            {
                return Task.FromResult(IdentityResult.Failed(new IdentityError
                {
                    Code = "UsernameAsPassword",
                    Description = "You cannot use your username as your password"
                }));
            }
            else if (String.IsNullOrEmpty(password) || password.Length < MinLength)
            {
                return Task.FromResult(IdentityResult.Failed(new IdentityError
                {
                    Code = "PasswordTooShort",
                    Description = "Password Too Short"
                }));
            }
            else if (!Int32.TryParse(password, out i))
            {
                return Task.FromResult(IdentityResult.Failed(new IdentityError
                {
                    Code = "PasswordRequireNumber",
                    Description = "Password Require Number"
                }));
            }
            else if (!Int32.TryParse(password, out i))
            {
                return Task.FromResult(IdentityResult.Failed(new IdentityError
                {
                    Code = "PasswordRequireNumber",
                    Description = "Password Require Number"
                }));
            }

            return Task.FromResult(IdentityResult.Success);
        }
    }
}