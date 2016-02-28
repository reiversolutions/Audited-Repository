using AuditedRepository.Interfaces.Models;
using AuditedRepository.Interfaces.Parsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuditedRepository.Enums;
using AuditedRepository.Models;

namespace AuditedRepository.Parsers
{
    public abstract class ParserBase<T> : IParser<T> where T : class, IEntity
    {
        public IAuditEntity Parse(T entity, AuditAction auditAction)
        {
            var stringifiedObj = Parse(entity);

            return new AuditEntity()
            {
                Data = stringifiedObj
            };
        }

        public virtual string Parse(T entity)
        {
            return string.Format("{0} - {1}", entity.Id, DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
        }
    }
}
