using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;
using WebMVCR1.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

            [TestMethod]
            public void ActionExecutes_ReturnView()
            {
                MyController controller = new MyController();
                var result = controller.Index();
                Assert.IsNotNull(result);
            }
            [TestMethod]
            public void IndexStringInViewData()
            {
                MyController controller = new MyController();
                ViewResult result = controller.Index() as ViewResult;
                Assert.AreEqual("Добрый день", result.ViewData["Greeting"]);
            }
    }
}
