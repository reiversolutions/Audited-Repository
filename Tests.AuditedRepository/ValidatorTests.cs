using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AuditedRepository.Validators;
using AuditedRepository.Interfaces.Models;
using AuditedRepository.Interfaces.Validators;
using AuditedRepository.Models;
using Tests.AuditedRepository.Models;
using Tests.AuditedRepository.Constants;

namespace Tests.AuditedRepository
{
    [TestClass]
    public class ValidatorTests
    {
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
            var result = validator.Validate(MockObject.EMPTY_ENTITY);

            // Assert
        }

        [TestMethod]
        public void ValidateClass_Basic()
        {
            // Assign
            IValidator<IEntity> validator = new EntityValidator<IEntity>();

            // Act
            var result = validator.Validate(MockObject.BASIC_ENTITY);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidateClass_BaseInherited()
        {
            // Assign
            IValidator<IEntity> validator = new EntityValidator<IEntity>();

            // Act
            var result = validator.Validate(MockObject.BASIC_MOCKENTITY);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
