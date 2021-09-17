using ProGitForProgrammers;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange
            var customer = new Customer()
            {FirstName="Ali",
            LastName="ghorbani"
            };

            //Act
            var except = "ghorbani Ali";

            //Assert
            Assert.Equal(except, customer.FullName);
        }
        [Fact]
        public void Test2()
        {
            //arrange
            var customer = new Customer()
            {FirstName="Ali"
            };

            //Act
            var except = " Ali";

            //Assert
            Assert.Equal(except, customer.FullName);
        }
    }
}
