using AutoMapper;
using System.Threading.Tasks;
using UBSI_Ops.server.Entities;
using UBSI_Ops.server.MediaAgencies.Models;
using UBSI_Ops.server.Services.Intefaces;

namespace UBSI_Ops.server.MediaAgencies.Services
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
