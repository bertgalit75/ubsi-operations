﻿using AutoMapper;
using UBSI_Ops.server.AccountExecutives.Models;
using UBSI_Ops.server.Customers.Models;
using UBSI_Ops.server.Entities;
using UBSI_Ops.server.MediaAgencies.Models;
using UBSI_Ops.server.Entities.Identity;
using UBSI_Ops.server.RadioStations.Models;
using UBSI_Ops.server.UserRoles.Models;
using UBSI_Ops.server.Users.Models;
using UBSI_Ops.server.Vendors.Models;

namespace UBSI_Ops.server.AutoMapperProfile
{
    public class AutoMapperProfileConfiguration : Profile
    {
        public AutoMapperProfileConfiguration() : this("My Profile")
        {
        }

        private AutoMapperProfileConfiguration(string profileName) : base(profileName)
        {
            CreateMap<MediaAgency, MediaAgencyDto>();
            CreateMap<MediaAgencyDto, MediaAgency>();
            CreateMap<RadioStation, RadioStationDto>();
            CreateMap<Customer, CustomerDto>();
            CreateMap<User, UserDto>();
            CreateMap<UserRole, UserRoleDto>();
            CreateMap<Vendor, VendorDto>();
            CreateMap<AccountExecutive, AccountExecutiveDto>();
            CreateMap<MediaAgency, MediaAgencyDto>();
        }
    }
}
