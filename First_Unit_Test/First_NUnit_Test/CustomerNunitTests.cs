﻿using First_Unit_Test;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_NUnit_Test
{
    [TestFixture]
    public class CustomerNunitTests
    {
        private Customer customer;
        [SetUp]
        public void Setup()
        {
            customer = new Customer();
        }

        [Test]
        public void FirstLastName_ReturnFullName()
        {
            //Arrange
            
            //Act
            customer.GreatingWithNames("Oguz", "Kumcular");
            //Assert
            Assert.AreEqual(customer.GreetingMessage, "Hello, Oguz Kumcular");
            Assert.That(customer.GreetingMessage, Is.EqualTo("Hello, Oguz Kumcular"));
            Assert.That(customer.GreetingMessage, Does.Contain("oguz Kumcular").IgnoreCase);
            Assert.That(customer.GreetingMessage, Does.StartWith("Hello,"));
            Assert.That(customer.GreetingMessage, Does.EndWith("Kumcular"));
            Assert.That(customer.GreetingMessage, Does.Match("Hello, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]"));

        }
        [Test]
        public void GreetingMessageReturnsNull()
        {
            //arrange
           
            //act
          
            //assert
            Assert.IsNull(customer.GreetingMessage);
        }
    }
}
