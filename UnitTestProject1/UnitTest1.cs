using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleRESTforCI.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ValuesController controller = new ValuesController();
            ActionResult<IEnumerable<string>> actResult = controller.Get();
            IEnumerable<string> values = actResult.Value;
            Assert.AreEqual(2, values.Count());
        }
    }
}
