using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PassEstim;

namespace PassMarker.Tests
{
    [TestClass]
    public class PassEstimTests
    {
        [TestMethod]
        public void estimPass_passOnlyDigis_return1()
        {
            string password = "111";
            int expected = 1;

            PassEstimator passEstimator = new PassEstimator();
            int mark = passEstimator.estimPass(password);

            Assert.AreEqual(expected, mark);
        }

        [TestMethod]
        public void estimPass_passDigisAndLowerCase_return2()
        {
            string password = "11a";
            int expected = 2;

            PassEstimator passEstimator = new PassEstimator();
            int mark = passEstimator.estimPass(password);

            Assert.AreEqual(expected, mark);
        }

        [TestMethod]
        public void estimPass_passDigisAndBothCase_return3()
        {
            string password = "11aA";
            int expected = 3;

            PassEstimator passEstimator = new PassEstimator();
            int mark = passEstimator.estimPass(password);

            Assert.AreEqual(expected, mark);
        }

        [TestMethod]
        public void estimPass_passDigisBothCaseAndSpecial_return4()
        {
            string password = "11aA@";
            int expected = 4;

            PassEstimator passEstimator = new PassEstimator();
            int mark = passEstimator.estimPass(password);

            Assert.AreEqual(expected, mark);
        }

        [TestMethod]
        public void estimPass_passDigisBothCaseAndSpecialLenght8_return5()
        {
            string password = "11aA@16A.";
            int expected = 5;

            PassEstimator passEstimator = new PassEstimator();
            int mark = passEstimator.estimPass(password);

            Assert.AreEqual(expected, mark);
        }

        [TestMethod]
        public void estimPass_passEmpty_return0()
        {
            string password = "";
            int expected = 0;

            PassEstimator passEstimator = new PassEstimator();
            int mark = passEstimator.estimPass(password);

            Assert.AreEqual(expected, mark);
        }
    }
}
