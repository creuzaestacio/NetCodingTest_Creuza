using FluentAssertions;
using System.Net;
using System.Threading.Tasks;
using Xunit;



namespace Icatu.EmployeeManagerAPI.Test.Testes
{
    public class EmployeesTest
    {
        private readonly TestContext _testContext;

        public EmployeesTest()
        {
            _testContext = new TestContext();
        }

        [Fact]
        public void Get_Employees()
        {
            var response = _testContext.Client.GetAsync("/api/employees");

            Assert.NotEmpty(response.Id.ToString());
        }

    }
}
