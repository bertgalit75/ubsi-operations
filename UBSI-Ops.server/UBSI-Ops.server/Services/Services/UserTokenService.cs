using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using UBSI_Ops.server.Entities.Identity;

namespace UBSI_Ops.server.Services.Services
{
    public class UserTokenService
    {
        private readonly TokenService _tokenService;

        public UserTokenService(TokenService tokenService)
        {
            _tokenService = tokenService;
        }

        public ClaimsPrincipal Decode(string encodedToken)
        {
            return _tokenService.Decode(encodedToken);
        }

        /// <summary>
        /// Create a token from a user.
        /// The token service does not ensure that user is to be given a token.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="userOrganization"></param>
        /// <returns></returns>
        public string CreateAccessToken(User user)
        {
            var claims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id),
            };

            return _tokenService.Encode(
                timeToExpire: TimeSpan.FromHours(24),
                customClaims: claims);
        }

        public string CreateInvitationToken(User user, string role, string organization)
        {
            var claims = new List<Claim>
            {
            };

            return _tokenService.Encode(
                timeToExpire: TimeSpan.FromHours(168),
                customClaims: claims);
        }

        public string CreateResetPasswordToken(User user)
        {
            var claims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id)
            };

            return _tokenService.Encode(
                timeToExpire: TimeSpan.FromMinutes(10),
                customClaims: claims);
        }
    }
}
