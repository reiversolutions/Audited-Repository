using AuditedRepository.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditedRepository.Interfaces.Validators
{
    public interface IValidator<T> where T : IEntity
    {
        bool Validate(T entity);
    }
}
