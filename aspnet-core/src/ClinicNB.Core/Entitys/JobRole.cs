using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicNB.Entitys
{
    public class JobRole: AuditedAggregateRoot<int>
    {
        public int JobId { get; set; }
        public string JobName { get; set; }
        public int Rid { get; set; }
        public string Rname { get; set; }
    }
}
