using Microsoft.VisualStudio.TestTools.UnitTesting;
using TasmSite.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Diagnostics;

namespace TasmSite.Controllers.Tests
{
    [TestClass()]
    public class DeviceGroupControllerTests
    {
        [TestMethod()]
        public void IndexTest()
        {
            //Arrange
            DeviceGroupController controller = new DeviceGroupController();
            //Act
            ViewResult result = controller.Index() as ViewResult;
            Console.WriteLine(result.Model.ToString());
            Console.WriteLine(result.ViewData.Keys.ToString());
            Console.WriteLine(result.ViewData.Values.ToString());
            Console.WriteLine(result.ViewBag.Message);
            Console.WriteLine(result.ViewName);
            //Assert

        }

        [TestMethod()]
        public void DetailsTest()
        {
            //Arrange
            DeviceGroupController controller = new DeviceGroupController();
            //Act
            ViewResult result = controller.Details() as ViewResult;
            Debug.Write(result.Model.ToString());
            Debug.Write(result.ViewData.Keys.ToString());
            Debug.Write(result.ViewData.Values.ToString());
            Debug.Write(result.ViewBag.Message);
            Debug.Write(result.ViewName);
            //Assert

        }

        [TestMethod()]
        public void CreateTest()
        {
            //Arrange
            DeviceGroupController controller = new DeviceGroupController();
            //Act
            ViewResult result = controller.Create() as ViewResult;
            //Assert

        }

        [TestMethod()]
        public void EditTest()
        {
            //Arrange
            DeviceGroupController controller = new DeviceGroupController();
            //Act
            ViewResult result = controller.Edit() as ViewResult;
            //Assert

        }
    }
}