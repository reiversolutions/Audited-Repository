using AuditedRepository.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditedRepository.Interfaces.Models
{
    public interface IAuditEntity : IEntity
    {
        /// <summary>
        /// Entity type
        /// </summary>
        string Type { get; set; }

        /// <summary>
        /// Data audit
        /// </summary>
        string Data { get; set; }

        /// <summary>
        /// Database action
        /// </summary>
        AuditAction Action { get; set; }
    }
}
