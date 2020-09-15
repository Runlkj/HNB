using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClinicNB.Entitys
{
    public class PinInfo : AuditedAggregateRoot<int>
    {
        [StringLength(50)]
        public string PName { get; set; }
    }
}
