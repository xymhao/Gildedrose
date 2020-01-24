using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GildedroseTests
{
    [TestClass]
    public class CanaryTest
    {
        [TestMethod]
        public void should_be_able_to_run_a_trivial_test_case()
        {
            Assert.AreEqual(1 + 2, (3));
        }

        [TestMethod]
        public void should_be_able_to_use_guava_capabilities()
        {
            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            //List<int> doubled = numbers.Select(x => x * 2).ToList();
            //Assert.AreEqual(doubled, new List<int>() { 1, 2, 3, 4, 5 });
            //String src = Files.toString(new File("src/test/java/CanaryTest.java"), UTF_8);
            //Assert.AreEqual(src.length(), (954));
        }
    }
}
