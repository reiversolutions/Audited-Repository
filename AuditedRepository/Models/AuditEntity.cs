using AuditedRepository.Enums;
using AuditedRepository.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditedRepository.Models
{
    /// <summary>
    /// Audit base model for entities
    /// </summary>
    public class AuditEntity : Entity, IAuditEntity
    {
        public string Type { get; set; }

        public string Data { get; set; }
        public AuditAction Action { get; set; }
    }
}
