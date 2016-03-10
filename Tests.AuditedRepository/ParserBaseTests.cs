using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AuditedRepository.Interfaces.Models;
using AuditedRepository.Models;
using AuditedRepository.Interfaces.Parsers;
using Tests.AuditedRepository.Models;
using Tests.AuditedRepository.Constants;

namespace Tests.AuditedRepository
{
    [TestClass]
    public class ParserBaseTests
    {
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
            var result = parser.Parse(MockObject.EMPTY_ENTITY);

            // Assert
        }

        [TestMethod]
        public void ParseBaseClass_Basic()
        {
            // Assign
            IParser<IEntity> parser = new MockParserBase<IEntity>();
            
            // Act
            var result = parser.Parse(MockObject.BASIC_ENTITY);

            // Assert
            Assert.IsTrue(result.Contains(MockObject.BASIC_ENTITY.Id));
        }

        [TestMethod]
        public void ParseBaseClass_BaseInherited()
        {
            // Assign
            IParser<IEntity> parser = new MockParserBase<IEntity>();

            // Act
            var result = parser.Parse(MockObject.BASIC_MOCKENTITY);

            // Assert
            Assert.IsTrue(result.Contains(MockObject.BASIC_MOCKENTITY.Id));
        }
    }
}
