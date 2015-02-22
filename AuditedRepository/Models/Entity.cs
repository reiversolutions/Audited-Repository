using AuditedRepository.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditedRepository.Models
{
    /// <summary>
    /// Entity base model
    /// </summary>
    public class Entity : MaintenanceProperties, IEntity
    {
        public string Id { get; set; }
    }
}
