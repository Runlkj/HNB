using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicNB.Entitys
{
    public class MestInfo : AuditedAggregateRoot<int>
    {
        //西药处方单
        public int CDan	  { get; set; }
        public int CDay	  { get; set; }
        public int CPing	  { get; set; }
        public int CUserType { get; set; }
        public int CPin	  { get; set; }
        public decimal CSum { get; set; }
    }
}
