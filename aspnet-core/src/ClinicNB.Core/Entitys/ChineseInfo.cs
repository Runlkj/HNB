using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicNB.Entitys
{
    public class ChineseInfo: AuditedAggregateRoot<int>
    {
        //中药处方单
        public int CDan	  { get; set; }
        public int CNum	  { get; set; }
        public int CUserType { get; set; }
        public int CPin	  { get; set; }
        public decimal CSum	  { get; set; }
        public int UPId { get; set; }
    }
}
