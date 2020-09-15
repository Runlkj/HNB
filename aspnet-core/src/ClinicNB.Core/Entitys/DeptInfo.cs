using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicNB.Entitys
{
    public class DeptInfo: AuditedAggregateRoot<int>
    {
        public string Dname { get; set; }
    }
}
