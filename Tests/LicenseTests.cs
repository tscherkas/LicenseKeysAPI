using System;
using Xunit;
using Licenses;
using System.ComponentModel.DataAnnotations;

namespace Tests
{
    public class LicenseTests
    {
        [Fact]
        public void LicenseCustomerNameLength()
        {
            var licence = new License(new Guid(),
                "aaaaaf".Replace("a","abcdeabcde"),
                DateTime.Now,
                DateTime.Now);
            Assert.Throws<ValidationException>(
                () => licence.Validate());
        }

        [Fact]
        public void LicenseExpirationDate()
        {
            var licence = new License(new Guid(),
                "Expired licence",
                DateTime.Now,
                DateTime.Parse("1900-01-01"));
            Assert.Throws<ValidationException>(
                () => licence.Validate());
        }
        [Fact]
        public void LicenseRequiredFields()
        {
            var licence = new License(new Guid(),
                String.Empty,
                DateTime.Now,
                DateTime.Parse("1900-01-01"));
            Assert.Throws<ValidationException>(
                () => licence.Validate());
        }

        [Fact]
        public void LicenseCanGenerateKey()
        {
            var licence = new License(new Guid(),
                "Customer name Example",
                DateTime.Now,
                DateTime.Parse("1900-01-01"));
            Assert.True(licence.LicenceKey.Length > 0);
        }
    }
}
