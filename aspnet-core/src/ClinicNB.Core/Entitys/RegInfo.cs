using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicNB.Entitys
{
    public class RegInfo:AuditedAggregateRoot<int>
    {
        public string GDanhao { get; set; }
        public int KeShi { get; set; }
        public string LType { get; set; }
        public int Doctor { get; set; }
        public int Price { get; set; }
        public DateTime GDate { get; set; }
        public string GuaName { get; set; }
        public string GName { get; set; }
        public string GNum { get; set; }
        public int GAge { get; set; }
        public DateTime GBirthday { get; set; }
        public string GSex { get; set; }
        public string GTel { get; set; }
        public string GZheng { get; set; }
        public string GXiang { get; set; }
        public string GZhen { get; set; }
        public string GYizhu { get; set; }
        public int Yid { get; set; }
        public string Zhuang { get; set; }
    }
}
