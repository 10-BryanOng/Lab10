using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestSuite
    {
        private float result = 0.0f;

        //Addition
        [Test]
        public void TestAddition()
        {
            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);
        }
        [UnityTest]
        public IEnumerator TestUnityAddition()
        {
            yield return null;

            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);
        }

        //Subtraction
        [Test]
        public void TestSubtraction()
        {
            result = Calculator.CalculatePair(5, 2, "-");
            Assert.AreEqual(result, 3);
        }
        [UnityTest]
        public IEnumerator TestUnitySubtraction()
        {
            yield return null;

            result = Calculator.CalculatePair(5, 2, "-");
            Assert.AreEqual(result, 3);
        }

        //Multiplication
        [Test]
        public void TestMultiply()
        {
            result = Calculator.CalculatePair(5, 2, "*");
            Assert.AreEqual(result, 10);
        }
        [UnityTest]
        public IEnumerator TestUnityMultiply()
        {
            yield return null;

            result = Calculator.CalculatePair(5, 2, "*");
            Assert.AreEqual(result, 10);
        }

        //Division
        [Test]
        public void TestDivision()
        {
            result = Calculator.CalculatePair(10, 2, "/");
            Assert.AreEqual(result, 5);
        }
        [UnityTest]
        public IEnumerator TestUnityDivision()
        {
            yield return null;

            result = Calculator.CalculatePair(10, 2, "/");
            Assert.AreEqual(result, 5);
        }

        [Test]
        public void TestPower()
        {
            result = Calculator.CalculatePair(5, 2, "^");
            Assert.AreEqual(result, 25);
        }

        [UnityTest]
        public IEnumerator TestUnityPower()
        {
            yield return null;

            result = Calculator.CalculatePair(5, 2, "^");
            Assert.AreEqual(result, 25);
        }

        //Square Root
        public void TestSQRT()
        {
            result = Calculator.CalculatePair(100, 0, "√");
            Assert.AreEqual(result, 10);
        }
        [UnityTest]
        public IEnumerator TestUnitySQRT()
        {
            yield return null;

            result = Calculator.CalculatePair(100, 0, "√");
            Assert.AreEqual(result, 10);
        }
    }
}
