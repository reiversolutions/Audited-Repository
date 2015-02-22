using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditedRepository.Interfaces.Models
{
    public interface IEntity : IMaintenanceProperties
    {
        /// <summary>
        /// Primary key
        /// </summary>
        string Id { get; set; }
    }
}