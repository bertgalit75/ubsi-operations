using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UBSI_Ops.server.CertificatesofPerformance.Models;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.Services.Intefaces;

namespace UBSI_Ops.server.CertificatesofPerformance.Services
{
    public class CertificateOfPerformanceService
    {
        private readonly IMapper _mapper;
        private readonly ICertificateOfPerformance _certificateOfPerformance;

        public CertificateOfPerformanceService(IMapper mapper,
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
