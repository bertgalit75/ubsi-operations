using AutoMapper;
using Ropes.API.AccountExecutives.Models;
using Ropes.API.BillingStatements;
using Ropes.API.BillingStatements.Models;
using Ropes.API.Customers.Models;
using Ropes.API.Entities;
using Ropes.API.Entities.Identity;
using Ropes.API.ImplementationOrders;
using Ropes.API.ImplementationOrders.Models;
using Ropes.API.MediaAgencies.Models;
using Ropes.API.RadioStations.Models;
using Ropes.API.Roles.Models;
using Ropes.API.UserRoles.Models;
using Ropes.API.Users.Models;
using Ropes.API.Vendors.Models;

namespace Ropes.API.AutoMapperProfile
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
            CreateMap<Role, RoleDto>();
            CreateMap<Vendor, VendorDto>();
            CreateMap<AccountExecutive, AccountExecutiveDto>();
            CreateMap<MediaAgency, MediaAgencyDto>();

            CreateMap<Role, RoleDto>();
            CreateMap<CreateImplementationOrderDto, ImplementationOrder>();
            CreateMap<CreateImplementationOrderDto.BookingDto, ImplementationOrderBooking>();

            CreateMap<ImplementationOrder, ImplementationOrderDto>();
            CreateMap<ImplementationOrderBooking, ImplementationOrderDto.BookingDto>();

            CreateMap<Role, RoleDto>();
            CreateMap<Role, CreateRoleDto>();

            CreateMap<BillingStatement, BillingStatementDto>();
        }
    }
}
