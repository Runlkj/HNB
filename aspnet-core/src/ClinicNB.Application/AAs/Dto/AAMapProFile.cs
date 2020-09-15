using AutoMapper;
using ClinicNB.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicNB.AAs.Dto
{
    public class AAMapProFile:Profile
    {
        public AAMapProFile  ()
        {
            CreateMap<AADto, AA>();
            CreateMap<CreateUpdateAADto, AA>();
        }
    }
}
