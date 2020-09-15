using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClinicNB.Entitys
{
    public class UserInfo : AuditedAggregateRoot<int>
    {
        //用法表
        [StringLength(50)]
        public string UName { get; set; }
    }
}
