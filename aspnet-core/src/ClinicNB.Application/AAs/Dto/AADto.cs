using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicNB.AAs.Dto
{
    public class AADto:EntityDto<int>
    {
        public int AAId { get; set; }

        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
        public int MyProperty3 { get; set; }
        public int MyProperty4 { get; set; }
    }
}
