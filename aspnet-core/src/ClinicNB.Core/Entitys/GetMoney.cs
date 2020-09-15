using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicNB.Entitys
{
    public class GetMoney: AuditedAggregateRoot<int>
    {
        public string Code { get; set; }
        public int GetMoneyTypeId { get; set; }
        public int RegInfoId { get; set; }
        public int OfficeInfoId { get; set; }
        public DateTime CreateTime { get; set; }
        public int GetQian { get; set; }
        public int GetTypeId { get; set; }
    }
}
