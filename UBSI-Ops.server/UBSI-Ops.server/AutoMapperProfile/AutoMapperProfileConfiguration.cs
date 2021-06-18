using AutoMapper;
using UBSI_Ops.server.Entities;
using UBSI_Ops.server.RadioStations.Models;
using UBSI_Ops.server.Customers.Models;

namespace UBSI_Ops.server.AutoMapperProfile
{
    public class AutoMapperProfileConfiguration : Profile
    {
        public AutoMapperProfileConfiguration() : this("My Profile")
        {
        }

        private AutoMapperProfileConfiguration(string profileName) : base(profileName)
        {
            CreateMap<RadioStation, RadioStationDto>();
            CreateMap<Customer, CustomerDto>();
        }
    }
}
