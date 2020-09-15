using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicNB.Entitys
{
    public class EjrInfo : AuditedAggregateRoot<int>
    {
        public int Eid { get; set; }
        public string Epno { get; set; }
        public string Ename { get; set; }
        public string LoginName { get; set; }
        public string Pwd { get; set; }
        public string Esex { get; set; }
        public int Eage { get; set; }
        public string Etel { get; set; }
        public string Ezs { get; set; }
        public string Etime { get; set; }
        public string Address { get; set; }
        public string Eperson { get; set; }
        public int Estate { get; set; }
        public int JobId { get; set; }
        public int JobName { get; set; }
        public int Rid { get; set; }
        public int Rname { get; set; }
    }
}
