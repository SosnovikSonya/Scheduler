using System;
using System.IO;
using System.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scheduler.Business.Entities.DataLoad;
using Scheduler.Business.Entities.DataLoad.Json;
using Scheduler.Business.Entities.DataLoad.Xml;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           

            var str = File.ReadAllText("schedule.json");
            JsonLoadSettings settings = new JsonLoadSettings(str);
            JsonData data = new JsonData(settings);
            var races = data.GetRaces();
        }
    }
}
