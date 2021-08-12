using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Ropes.API.CertificatesofPerformance.Models;
using Ropes.API.Core.Paging;
using Ropes.API.Services.Intefaces;
using System.Threading.Tasks;

namespace Ropes.API.CertificatesofPerformance.Services
{
    public class CertificateOfPerformanceService
    {
        private readonly IMapper _mapper;
        private readonly ICertificateOfPerformance _certificateOfPerformance;

        public CertificateOfPerformanceService(
            IMapper mapper,
            ICertificateOfPerformance certificateOfPerformance)
        {
            _mapper = mapper;
            _certificateOfPerformance = certificateOfPerformance;
        }

        public async Task<ActionResult<PaginatedList<CertificateOfPerformanceDto>>> CPList(PageOptions options)
        {
            var cps = await _certificateOfPerformance.ListCP(options);

            return cps.Select(r => _mapper.Map<CertificateOfPerformanceDto>(r));
        }
    }
}
