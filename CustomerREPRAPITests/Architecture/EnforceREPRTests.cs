using CustomerREPRAPI.Endpoints.Customer.CreateCustomer;
using CustomerREPRAPITests.Architecture;
using Microsoft.AspNetCore.Mvc;
using NetArchTest.Rules;

namespace CustomerREPRAPITests.ArchitectureTests
{
    public class EnforceREPRTests
    {
        [Test]
        public void Controllers_Should_Have_Only_One_Public_Method()
        {
            var result =  Types.InAssembly(typeof(CreateCustomerController).Assembly)
                .That()
                .AreClasses()
                .And()
                .Inherit(typeof(ControllerBase))
                .Should()
                .MeetCustomRule(new OnlyOnePublicMethodInControllerRule())
                .GetResult();

            Assert.True(result.IsSuccessful);
        }
    }
}