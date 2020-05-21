using Hatra.Entities.AuditableEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hatra.Entities
{
    public class HardwareLock: IAuditableEntity
    {
        public int Id { get; set; }
        public string ComputerName { get; set; }
        public string CpuSerialNumber { get; set; }
        public string LockSerialNumber { get; set; }
        public int CompanyCount { get; set; }
        public int FinancialYearCount { get; set; }
        public int DocumentCount { get; set; }
        public int UserCount { get; set; }
        public int AndroidUserCount { get; set; }
        public string CurrentVersion { get; set; }
        public bool IsBlocked { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string OwnerName { get; set; }
        public virtual ICollection<HardwareLockFinancialYear> FinancialYears { get; set; }

    }
}
