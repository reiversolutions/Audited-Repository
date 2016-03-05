using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AuditedRepository.Validators;
using AuditedRepository.Interfaces.Models;
using AuditedRepository.Interfaces.Validators;
using AuditedRepository.Models;

namespace Tests.AuditedRepository
{
    [TestClass]
    public class ValidatorTests
    {
        private IEntity EMPTY_ENTITY = new Entity();
        private IEntity BASIC_ENTITY = new Entity()
        {
            Id = Guid.NewGuid().ToString(),
            CreatedDate = DateTime.Now,
            ModifiedDate = DateTime.Now,
            IsArchived = false
        };

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void ValidateClass_null()
        {
            // Assign
            IValidator<IEntity> validator = new EntityValidator<IEntity>();
            IEntity entity = null;

            // Act
            var result = validator.Validate(entity);

            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateClass_Empty()
        {
            // Assign
            IValidator<IEntity> validator = new EntityValidator<IEntity>();

            // Act
            var result = validator.Validate(EMPTY_ENTITY);

            // Assert
        }

        [TestMethod]
        public void ValidateClass_Basic()
        {
            // Assign
            IValidator<IEntity> validator = new EntityValidator<IEntity>();

            // Act
            var result = validator.Validate(BASIC_ENTITY);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
