using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditedRepository.Interfaces.Models
{
    public interface IMaintenanceProperties
    {
        /// <summary>
        /// Has been archived
        /// </summary>
        bool IsArchived { get; set; }
        /// <summary>
        /// Last modified date
        /// </summary>
        DateTime ModifiedDate { get; set; }
        /// <summary>
        /// Date entity was created
        /// </summary>
        DateTime CreatedDate { get; set; }
    }
}