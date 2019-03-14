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
    }
}
