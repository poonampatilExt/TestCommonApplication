using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestCommonApplication.Controllers;
using Xunit;

namespace TestCommonApplicationForTest
{
    public class TestValues
    {
        [Fact]
        public void TestGetMethod()
        {
            ValuesController valuesController = new ValuesController();
            IEnumerable<string> result = valuesController.Get();

            Assert.Equal(result.Count(), 2);
        }
    }
}
