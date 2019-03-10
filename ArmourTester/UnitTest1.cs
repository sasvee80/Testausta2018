using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testing2018;


namespace ArmourTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Armour ar = new Armour("Jorma", "Kokkeli", 20, 2, 2);
            int lvl = ar.getLevel();
            if (lvl != 2)
        { 
            Assert.Fail
        }

   

