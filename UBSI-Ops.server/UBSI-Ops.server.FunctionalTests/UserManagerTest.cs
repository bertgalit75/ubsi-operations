﻿using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using UBSI_Ops.server.Entities.Identity;
using Xunit;

namespace UBSI_Ops.server.FunctionalTests
{
    public class UserManagerTest : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly CustomWebApplicationFactory _factory;

        public UserManagerTest(CustomWebApplicationFactory factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task ShouldVerifyPasswordAsCorrect()
        {
            // Arrange
            using var scope = _factory.Services.CreateScope();
            var userManager = (UserManager<User>)scope.ServiceProvider.GetRequiredService(typeof(UserManager<User>));

            var user = await userManager.FindByNameAsync("admin");

            // Act
            var result = await userManager.CheckPasswordAsync(user, "admin@!45");

            // Assert
            result.Should().BeTrue();
        }
    }
}