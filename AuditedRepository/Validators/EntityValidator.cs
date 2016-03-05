using AuditedRepository.Interfaces.Models;
using AuditedRepository.Interfaces.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditedRepository.Validators
{
    public class EntityValidator<T> : IValidator<T> where T : IEntity
    {
        public bool Validate(T entity)
        {
            if (entity == null)
            {
                throw new NullReferenceException("Entity to be parsed can not be null");
            }

            if (string.IsNullOrWhiteSpace(entity.Id))
            {
                throw new ArgumentException("Entity to be parsed must have a valid Id");
            }

            return true;
        }
    }
}
