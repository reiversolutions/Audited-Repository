using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditedRepository.Interfaces.Models
{
    public interface IMaintenanceProperties
    {
        bool IsArchived { get; set; }
        DateTime ModifiedDate { get; set; }
        DateTime CreatedDate { get; set; }
    }
}
