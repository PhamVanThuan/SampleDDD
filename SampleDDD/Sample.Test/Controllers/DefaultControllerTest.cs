using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Moq;
using NUnit.Framework;
using Sample.Entities;
using Sample.Web.Controllers;
using Sample.Services.Abstractions;

namespace Sample.Test.Controllers
{
    [TestFixture]
    public class DefaultControllerTest
    {
        private Mock<ICountryService> _mockCountryServie;
        [SetUp]
        public void SetUp()
        {
            var countries = new List<Country>
            {
                new Country
                {
                    Name = "Vietnam",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                }
            };
            _mockCountryServie = new Mock<ICountryService>();
            _mockCountryServie.Setup(m => m.GetAllCountries()).Returns(countries);
        }
        [Test]
        public void TestDefaultIndex()
        {
            var obj = new DefaultController(_mockCountryServie.Object);

            var result = obj.Index() as ViewResult;

            Assert.AreEqual("Index", result.ViewName);
        }
    }
}
