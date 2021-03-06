using Microsoft.Extensions.Configuration;
using System;

namespace Ropes.API.Data.Configuration
{
    [Obsolete("This should not be here")]
    public class JwtConfiguration
    {
        private readonly IConfiguration _configuration;

        public JwtConfiguration(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string Audience => _configuration["Jwt:Audience"];

        public string Issuer => _configuration["Jwt:Issuer"];

        public string Key => _configuration["Jwt:Key"];
    }
}
