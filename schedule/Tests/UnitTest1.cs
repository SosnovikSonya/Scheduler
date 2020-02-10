using System;
using System.IO;
using System.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scheduler.Business.Entities.DataLoad;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var str = File.ReadAllText("schedule.xml");
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(str);
            XMLLoadSettings settings = new XMLLoadSettings(doc);
            XMLData data = new XMLData(settings);
            var races = data.GetRaces();
        }
    }
}
