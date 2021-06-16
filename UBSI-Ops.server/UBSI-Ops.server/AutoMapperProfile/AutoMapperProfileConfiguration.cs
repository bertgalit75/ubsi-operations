using AutoMapper;
using UBSI_Ops.server.Customers.Models;
using UBSI_Ops.server.Entities;

namespace UBSI_Ops.server.AutoMapperProfile
{
    public class AutoMapperProfileConfiguration : Profile
    {
        public AutoMapperProfileConfiguration() : this("My Profile")
        {
        }

        private AutoMapperProfileConfiguration(string profileName) : base(profileName)
        {
            CreateMap<Customer, CustomerDto>();
        }
    }
}
