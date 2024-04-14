using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]//4-йтест: возрастающая последовательность длинной 5 чисел
        public void sequenceincreasing()
        {
            string input = "1,2,3,4,5";
            String anser=Logic.splitstring(input);
            Assert.AreEqual("Последовательность, возрастающая", anser);
        }
        [TestMethod()]//5-йтест: не возрастающая последовательность длинной 5 чисел
        public void sequencenotincreasing()
        {
            string input = "50,30,10,40,20";
            String anser = Logic.splitstring(input);
            Assert.AreEqual("Последовательность, не возрастающая", anser);
        }
        [TestMethod()]//1-йтест: возрастающая последовательность длинной 4 числа из примера
        public void testsequencenumberone()
        {
            string input = "1,4,7,8";
            String anser = Logic.splitstring(input);
            Assert.AreEqual("Последовательность, возрастающая", anser);
        }
        [TestMethod()]//2-йтест: не возрастающая последовательность длинной 4 числа из примера
        public void testsequencenumbertwo()
        {
            string input = "1,7,8,2";
            String anser = Logic.splitstring(input);
            Assert.AreEqual("Последовательность, не возрастающая", anser);
        }
        [TestMethod()]//3-йтест: не возрастающая последовательность длинной 4 числа из примера
        public void testsequencenumberthree()
        {
            string input = "1,6,6,8";
            String anser = Logic.splitstring(input);
            Assert.AreEqual("Последовательность, не возрастающая", anser);
        }
    }
}