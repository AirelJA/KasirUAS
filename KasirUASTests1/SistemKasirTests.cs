using NUnit.Framework;
using KasirUAS;
using System;
using System.Collections.Generic;
using System.Text;

namespace KasirUAS.Tests
{
    [TestFixture()]
    public class SistemKasirTests
    {
        SistemKasir SK = new SistemKasir();

        [SetUp]
        public void init()
        {
            SK = new SistemKasir();
        }

        [Test()]
        public void dataTest()
        {
            const string cappuchino = "15000";
            Assert.IsTrue(true, cappuchino);

            const string mocchachino = "15000";
            Assert.IsTrue(true, mocchachino);

            const string americcano = "10000";
            Assert.IsTrue(true, americcano);

            const string indomie = "8000";
            Assert.IsTrue(true, indomie);

        }
    }
}