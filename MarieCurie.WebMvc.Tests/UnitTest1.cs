using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarieCurie.WebMvc.Repositories;
using System.Collections.Generic;
using MarieCurie.WebMvc.Models;

namespace MarieCurie.WebMvc.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void getStylemvc_Test()
        {
            //arrange
            HelperServicesMockRepo1 repo = new HelperServicesMockRepo1();
            List<MyHelperService> centers = repo.getCenters();

            string dayOfWeek = DateTime.Now.DayOfWeek.ToString();
            int Hour = 10; // DateTime.Now.Hour;
            var center = centers[1];
            string result = "";

            //act
            if (center.checkOpenningHours(dayOfWeek, Hour))
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
            List<MyHelperService> centers = repo.getCenters();

            string dayOfWeek = DayOfWeek.Monday.ToString();
            int Hour = 17; // DateTime.Now.Hour;
            var center = centers[1];
            string result = "";

            //act
            result = center.nextOpenningHours(dayOfWeek, Hour);

            //assert
            Assert.IsTrue(result == "Open today until 11.00 pm");

            //"panel panel-warning col-md-4";


        }

        [TestMethod]
        public void getnextOpeningTimeTomorrowMvc_Test()
        {
            //arrange
            HelperServicesMockRepo1 repo = new HelperServicesMockRepo1();
            List<MyHelperService> centers = repo.getCenters();

            string dayOfWeek = DayOfWeek.Tuesday.ToString();
            int Hour = 21; // DateTime.Now.Hour;
            var center = centers[0];
            string result = "";

            //act
            result = center.nextOpenningHours(dayOfWeek, Hour);

            //assert
            Assert.IsTrue(result == "Reopens tomorrow 9.00 am");

            //"panel panel-warning col-md-4";


        }
    }
}
