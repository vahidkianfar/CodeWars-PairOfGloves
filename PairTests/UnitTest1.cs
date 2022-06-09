using CodeWars_PairOfGloves;

namespace Solution {
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTests()
        {
            Assertion(0, new string[] {"Green", "Blue", "Purple", "Gray"});
            Assertion(0, new string[] {});
            Assertion(0, new string[] {"Purple"});
      
            Assertion(1, new string[] {"Blue", "Purple", "Blue", "Gray", "Lime", "Black"});
            Assertion(1, new string[] {"Blue", "Aqua", "Blue", "Teal", "Blue", "Black"});
      
            Assertion(2, new string[] {"Blue", "Aqua", "Blue", "Brown", "Blue", "Orange", "Aqua"});
            Assertion(17, new string[]
            {
                "Gray", "Green", "Purple", "Brown", "Teal", "Yellow", "Orange", "Lime", "Brown", "Orange", "Brown",
                "Aqua",
                "Blue", "Teal", "Orange", "Violet", "Orange", "Blue", "Lime", "Red", "Violet", "Teal", "Orange", "Aqua",
                "Teal", "Gray",
                "Yellow", "Red", "Aqua", "Red", "Olive", "Violet", "Black", "Red", "Gray", "Purple", "Lime", "Gray",
                "Red", "Black", "Orange"
            });
        }
    
        private static void Assertion(int expected, string[] input) =>
            Assert.AreEqual(
                expected,
                PairOfGloves.NumberOfPairs(input),
      
                $"Input: [{string.Join(", ", input)}]"
      
            );
    }
}