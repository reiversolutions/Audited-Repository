using AuditedRepository.Interfaces.Models;
using AuditedRepository.Interfaces.Parsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuditedRepository.Enums;
using AuditedRepository.Models;
using AuditedRepository.Validators;

namespace AuditedRepository.Parsers
{
    public abstract class ParserBase<T> : IParser<T> where T : IEntity
    {
        public IAuditEntity Parse(T entity, AuditAction auditAction)
        {
            var stringifiedObj = Parse(entity);

            return new AuditEntity()
            {
                Id = Guid.NewGuid().ToString(),
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Action = auditAction,
                Type = entity.GetType().Name,
                Data = stringifiedObj
            };
        }

        public virtual string Parse(T entity)
        {
            var validator = new EntityValidator<T>();
            validator.Validate(entity);

            return string.Format(
                "{0} - {1}", 
                entity.Id, 
                DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")
            );
        }
    }
}
