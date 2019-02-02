using FluentAssertions;
using System;
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
        public async Task Get_Employees()
        {
            var response = await _testContext.Client.GetAsync("/api/employees/1/1");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }


    }
}
