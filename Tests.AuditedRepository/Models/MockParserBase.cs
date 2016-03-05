using AuditedRepository.Interfaces.Models;
using AuditedRepository.Interfaces.Parsers;
using AuditedRepository.Parsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.AuditedRepository.Models
{
    public class MockParserBase<T> : ParserBase<T>, IParser<T> where T : IEntity
    {

    }
}
