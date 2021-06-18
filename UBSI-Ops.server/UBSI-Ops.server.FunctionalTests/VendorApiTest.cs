﻿using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using UBSI_Ops.server.Vendors.Models;
using Xunit;

namespace UBSI_Ops.server.FunctionalTests
{
    public class VendorApiTest : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly CustomWebApplicationFactory _factory;

        public VendorApiTest(CustomWebApplicationFactory factory)
        {
            _factory = factory;
        }
        [Fact]
        public async Task ShouldRetrieveVendorList()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("/api/vendor");

            // Assert
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            var vendors = JsonSerializer.Deserialize<PaginatedListTest<VendorDto>>(responseContent, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            vendors.Items.Should().NotBeEmpty();
        }

        [Fact]
        public async Task ShouldRetrieveSpecificVendor()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("/api/vendor/8530220");

            // Assert
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            var vendor = JsonSerializer.Deserialize<VendorDto>(responseContent, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            vendor.VendorCode.Should().Be("8530220");
            vendor.VendorName.Should().Be("SALER SH..x");
        }
    }
}
