using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicNB.Entitys
{
    public class RoleInfo: AuditedAggregateRoot<int>
    {
        public string Rname { get; set; }
    }
}
