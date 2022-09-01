using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        //test ideas: X) OnlyOpenBracketsReturnsFalse X) OnlyCloseBracketsReturnsFalse X) NoBracketsReturnsTrue X) BalancedBracketsAroundTextReturnsTrue
        // X) UnbalancedBracketsBeforeStringReturnsFalse X) BalancedBracketsBeforeStringReturnsTrue X) UnbalancedBracketsAfterStringReturnsTrue X) BalancedBracketsAfterStringReturnsFalse
        // X) WrongOrderBracketsReturnsFalse 11) WrongOrderBracketsWithTextReturnsFalse 12) SingleBracketReturnsFalse

        [TestMethod]
        public void OnlyOpenBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[["));
        }


        [TestMethod]
        public void OnlyCloseBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]]"));
        }



        [TestMethod]
        public void NoBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Test Text"));
        }

        [TestMethod]
        public void BalancedBracketsAroundTextReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[Test Text]"));
        }


        [TestMethod]
        public void UnbalancedBracketsBeforeStringReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[[Test Text"));
        }

        [TestMethod]
        public void BalancedBracketsBeforeStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[] Test Text"));
        }


        [TestMethod]
        public void UnbalancedBracketsAfterStringReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Test Text]]"));
        }

        [TestMethod]
        public void BalancedBracketsAfterStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Test Text []"));
        }



        [TestMethod]
        public void WrongOrderedBracketsReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        [TestMethod]
        public void WrongOrderBracketsWithTextReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]Test Test["));
        }


        [TestMethod]
        public void EmptyStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }



    }
}
