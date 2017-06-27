using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarieCurie.Web.Models;
using System.Collections.Generic;
using MarieCurie.HelperServices.Repositories;
using MarieCurie.Web.Repositories;
using MarieCurie.Interview.Assets.Model;
using System.Linq;
using MarieCurie.HelperServices.Utilities;



namespace MarieCurie.Web.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void getStyle_Test()
        {
            //arrange
            HelperServicesMockRepo1 repo = new HelperServicesMockRepo1();
            List<HelperService> centers = repo.getCenters();

                        string DayOfWeek = DateTime.Now.DayOfWeek.ToString();
            int Hour = 10; // DateTime.Now.Hour;
            var center = centers[1];
            string result = "";

            //act
            if (HelperServicesUtility.checkOpenningHours(DayOfWeek, Hour, center))
                result = $"panel panel-warning col-md-3";
            else
                result = $"panel panel-default col-md-3";

            //assert
            Assert.IsTrue(result == "panel panel-default col-md-3");
            
                //"panel panel-warning col-md-4";


        }

        [TestMethod]
        public void getTodayOpenUntil_Test()
        {
            //arrange
            HelperServicesMockRepo1 repo = new HelperServicesMockRepo1();
            List<HelperService> centers = repo.getCenters();

            string dayOfWeek = DayOfWeek.Monday.ToString();
            int Hour = 17; // DateTime.Now.Hour;
            var center = centers[1];
            string result = "";

            //act
            result = HelperServicesUtility.nextOpenningHours(dayOfWeek, Hour, center);

            //assert
            Assert.IsTrue(result == "Open today until 8.00 pm");

            //"panel panel-warning col-md-4";


        }

        [TestMethod]
        public void getnextOpeningTimeTomorrow_Test()
        {
            //arrange
            HelperServicesMockRepo1 repo = new HelperServicesMockRepo1();
            List<HelperService> centers = repo.getCenters();

            string dayOfWeek = DayOfWeek.Tuesday.ToString();
            int Hour = 21; // DateTime.Now.Hour;
            var center = centers[1];
            string result = "";

            //act
            result = HelperServicesUtility.nextOpenningHours(dayOfWeek, Hour, center);

            //assert
            Assert.IsTrue(result == "Reopens tomorrow 5.00 pm");

            //"panel panel-warning col-md-4";


        }

        [TestMethod]
        public void TestMethod1()
        {
        }

    }
}
