using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;

namespace ClinicNB.Entitys
{
   public class yaoPinKuCun: AuditedAggregateRoot<int>
    {
        [StringLength(30)]
        public string YaoBianma { get; set; }
        [StringLength(30)]
        public string YaoName { get; set; }
        public int YaoTyPeID { get; set; }
        public string YaoChang { get; set; }
        public int YaoKucun { get; set; }
        public int YaoPrice { get; set; }
        [StringLength(30)]
        public string YaoGuige { get; set; }
        public int YaoZt { get; set; }
        public DateTime YaoTime { get; set; }
    }
}
