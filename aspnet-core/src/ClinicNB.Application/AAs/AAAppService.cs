using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using ClinicNB.AAs.Dto;
using ClinicNB.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicNB.AAs
{
    public class AAAppService: CrudAppService<
        AA,
        AADto,
        int,
        PagedAndSortedResultRequestDto,
        CreateUpdateAADto
        >,IAAAppService
    {
        public AAAppService(IRepository<AA, int> ss): base(ss)
        {

        }
        public override AADto Create(CreateUpdateAADto input)
        {
            return base.Create(input);
        }
    }
}
