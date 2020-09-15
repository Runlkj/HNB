using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;

namespace ClinicNB.Entitys
{
   public class yaoPinRuku: AuditedAggregateRoot<int>
    {
        [StringLength(30)]
        public string Yaoruku { get; set; }
        public DateTime YaorukuTime { get; set; }
        public int YaorukurenID { get; set; }
        [StringLength(30)]
        public string Yaogys { get; set; }
        public DateTime YaozhidanTime { get; set; }
        [StringLength(30)]
        public string YaoBeizhu { get; set; }
        public int YaopinId { get; set; }
    }
}
