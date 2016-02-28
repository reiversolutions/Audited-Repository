using AuditedRepository.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditedRepository.Interfaces.Parsers
{
    public interface IParser<T> where T : class, IEntity
    {
        string Parse(T entity);
    }
}
