using AuditedRepository.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.AuditedRepository.Models
{
    public interface IMockEntity : IEntity
    {
        string Message { get; set; }
        bool IsTest { get; set; }
    }
}
