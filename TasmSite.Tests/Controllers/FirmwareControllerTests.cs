using Microsoft.VisualStudio.TestTools.UnitTesting;
using TasmSite.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace TasmSite.Controllers.Tests
{
    [TestClass()]
    public class FirmwareControllerTests
    {
        [TestMethod()]
        public void IndexTest()
        {
            //Arrange
            FirmwareController controller = new FirmwareController();
            ViewResult result = controller.Index() as ViewResult;
            //Act
            //Assert
            Assert.Fail();
        }

        [TestMethod()]
        public void DetailsTest()
        {
            //Arrange
            FirmwareController controller = new FirmwareController();
            //Act
            ViewResult result = controller.Details() as ViewResult;
            //Assert
            Assert.Fail();
        }

        [TestMethod()]
        public void CreateTest()
        {
            //Arrange
            FirmwareController controller = new FirmwareController();
            //Act
            ViewResult result = controller.Create() as ViewResult;
            //Assert
            Assert.Fail();
        }

        [TestMethod()]
        public void EditTest()
        {
            //Arrange
            FirmwareController controller = new FirmwareController();
            //Act
            ViewResult result = controller.Edit() as ViewResult;
            //Assert
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteTest()
        {
            //Arrange
            FirmwareController controller = new FirmwareController();
            //Act
            ViewResult result = controller.Delete() as ViewResult;
            //Assert
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteConfirmedTest()
        {
            //Arrange
            FirmwareController controller = new FirmwareController();
            //Act
            ViewResult result = controller.DeleteConfirmed() as ViewResult;
            //Assert
            Assert.Fail();
        }
    }
}