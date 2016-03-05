using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AuditedRepository.Interfaces.Models;
using AuditedRepository.Models;
using AuditedRepository.Interfaces.Parsers;
using Tests.AuditedRepository.Models;

namespace Tests.AuditedRepository
{
    [TestClass]
    public class ParserBaseTests
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
        public void ParseBaseClass_null()
        {
            // Assign
            IParser<IEntity> parser = new MockParserBase<IEntity>();
            IEntity entity = null;

            // Act
            var result = parser.Parse(entity);

            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ParseBaseClass_Empty()
        {
            // Assign
            IParser<IEntity> parser = new MockParserBase<IEntity>();
            
            // Act
            var result = parser.Parse(EMPTY_ENTITY);

            // Assert
        }

        [TestMethod]
        public void ParseBaseClass_Basic()
        {
            // Assign
            IParser<IEntity> parser = new MockParserBase<IEntity>();
            
            // Act
            var result = parser.Parse(BASIC_ENTITY);

            // Assert
            Assert.IsTrue(result.Contains(BASIC_ENTITY.Id));
        }
    }
}
