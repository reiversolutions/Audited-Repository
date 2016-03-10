using AuditedRepository.Interfaces.Models;
using AuditedRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.AuditedRepository.Models;

namespace Tests.AuditedRepository.Constants
{
    public static class MockObject
    {
        public static IEntity EMPTY_ENTITY = new Entity();
        public static IEntity BASIC_ENTITY = new Entity()
        {
            Id = Guid.NewGuid().ToString(),
            CreatedDate = DateTime.Now.Date,
            ModifiedDate = DateTime.Now.Date,
            IsArchived = false
        };
        public static IMockEntity BASIC_MOCKENTITY = new MockEntity()
        {
            Id = Guid.NewGuid().ToString(),
            CreatedDate = DateTime.Now.Date,
            ModifiedDate = DateTime.Now.Date,
            IsArchived = false,
            Message = "Testing",
            IsTest = true
        };
    }
}
