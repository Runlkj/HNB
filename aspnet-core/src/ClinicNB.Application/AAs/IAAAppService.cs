using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ClinicNB.AAs.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicNB.AAs
{
    public interface IAAAppService: ICrudAppService<AADto,int, PagedAndSortedResultRequestDto,CreateUpdateAADto>
    {
    }
}
