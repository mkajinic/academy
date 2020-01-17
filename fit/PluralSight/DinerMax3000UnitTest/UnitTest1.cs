﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DinerMax3000UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            System.Collections.Generic.List<DinerMax3000.Business.Menu> resultMenus = NewMethod();

            int countBeforeSave = resultMenus[0].Items.Count;
            resultMenus[0].SaveNewMenuItem("UT_Name", "UT_Description", 8.00);

            resultMenus = DinerMax3000.Business.Menu.GetAllMenus();
            int countAfterSave = resultMenus[0].Items.Count;

            Assert.IsTrue(countBeforeSave < countAfterSave);

        }

        private static System.Collections.Generic.List<DinerMax3000.Business.Menu> NewMethod()
        {
            var resultMenus = DinerMax3000.Business.Menu.GetAllMenus();
            Assert.IsTrue(resultMenus.Count > 0);
            return resultMenus;
        }
    }
}
