﻿using FluentAssertions;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using UBSI_Ops.server.Entities.Identity;
using Xunit;

namespace UBSI_Ops.server.FunctionalTests
{
    public class UserManagerTest : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly UserManager<User> _userManager;
        private readonly CustomWebApplicationFactory _factory;
        public UserManagerTest(CustomWebApplicationFactory factory)
        {
            _factory = factory;
            _userManager = (UserManager<User>)_factory.Services.GetService(typeof(UserManager<User>));
        }

        [Fact]
        public async Task Test()
        {
            // Arrange
            var user = await _userManager.FindByNameAsync("admin");

            // Act
            var result = await _userManager.CheckPasswordAsync(user, "admin@!45");

            // Assert
            result.Should().BeTrue();
        }


    }
}
