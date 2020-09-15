using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicNB.Entitys
{
    public class CaseInfo: AuditedAggregateRoot<int>
    {
        //病历信息表
        public string BGuo { get; set; }
        public string BJia { get; set; }
        public string BGe	 { get; set; }
        public string BFu	 { get; set; }
        public DateTime BFa { get; set; }

    }
}
