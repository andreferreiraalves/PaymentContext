using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class DocumentTest
    {
        // Red, Green, Refactor
        [TestMethod]
        public void ShouldReturnErrorWhenCNPJIsInvalid()
        {
            var doc = new Document("", EDocumentType.CNPJ);
            Assert.IsTrue(doc.Invalid);


            foreach (var item in doc.Notifications)
            {
                Console.WriteLine(item);
            }
        }

        [TestMethod]
        public void ShouldReturnSucessWhenCNPJIsValid()
        {
            var doc = new Document("53216453000116", EDocumentType.CNPJ);
            Assert.IsTrue(doc.Valid);
        }

        // [TestMethod]
        // public void ShouldReturnErrorWhenCPFIsInvalid()
        // {
        //     var doc = new Document("321", EDocumentType.CPF);
        //     Assert.IsTrue(doc.Invalid);
        // }

        // [TestMethod]
        // public void ShouldReturnSucessWhenCPFIsValid()
        // {
        //     var doc = new Document("33333333333", EDocumentType.CPF);
        //     Assert.IsTrue(doc.Valid);
        // }
    }
}
