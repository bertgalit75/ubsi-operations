using AutoMapper;
using System.Threading.Tasks;
using Ropes.API.Entities;
using Ropes.API.MediaAgencies.Models;
using Ropes.API.Services.Intefaces;

namespace Ropes.API.MediaAgencies.Services
{
    public class MediaAgencyService
    {
        private readonly IMediaAgencyRepository _mediaAgencyRepository;
        private readonly IMapper _mapper;

        public MediaAgencyService(IMediaAgencyRepository mediaAgencyRepository,
            IMapper mapper)
        {
            _mediaAgencyRepository = mediaAgencyRepository;
            _mapper = mapper;
        }

        public async Task<MediaAgencyDto> CreateMediaAgency(MediaAgencyDto dto)
        {
            var mediaAgency = _mapper.Map<MediaAgency>(dto);

            await _mediaAgencyRepository.CreateMediaAgency(mediaAgency);

            return _mapper.Map<MediaAgencyDto>(mediaAgency);
        }
    }
}
