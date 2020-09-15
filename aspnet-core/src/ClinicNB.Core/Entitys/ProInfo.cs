using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicNB.Entitys
{
    public class ProInfo: AuditedAggregateRoot<int>
    {
        public string Name { get; set; }
        public int PId { get; set; }
    }
}
