using Coterie.Api.Services;
using NUnit.Framework;

namespace Coterie.UnitTests
{
    /* Sample service setup and teardown is provided
    For more info - https://docs.nunit.org/articles/nunit/writing-tests/attributes/setup.html */
    
    public class TestServiceTestsBase
    {
        // Sample Moq setup
        // protected Mock<ITestService> MockTestService;

        protected TestService TestService;

        [OneTimeSetUp]
        public void BaseOneTimeSetup()
        {
            //MockTestService = new Mock<ITestService>();

            TestService = new TestService();
        }

        [TearDown]
        public void Cleanup()
        {
            // Sample reset after each test is ran
            //MockTestService.Reset();
        }
    }
}