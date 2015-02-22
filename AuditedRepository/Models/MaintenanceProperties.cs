using AuditedRepository.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditedRepository.Models
{
    /// <summary>
    /// Maintenance properties only
    /// </summary>
    public class MaintenanceProperties : IMaintenanceProperties
    {
        public bool IsArchived { get; set; }

        public DateTime ModifiedDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
