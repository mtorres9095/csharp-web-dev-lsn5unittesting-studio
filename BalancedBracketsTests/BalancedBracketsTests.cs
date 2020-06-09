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
        [TestMethod]
        public void LaunchCodeInsideBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"));
        }
        [TestMethod]
        public void OnlyTheLeftBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }
        [TestMethod]
        public void NothingInsideTheBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }
        [TestMethod]
        public void LaunchCodeWithBracketsUpFrontReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode"));
        }
        [TestMethod]
        public void LaunchCodeWithBracketsOnCodeReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launch[Code]"));
        }
        [TestMethod]
        public void LaunchCodeWithOneBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[LaunchCode"));
        }
        [TestMethod]
        public void LaunchCodeWithBracketInTheCenterReturnsfalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code"));
        }
        [TestMethod]
        public void TwoBracketsOnOppositeDirectionsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }
        [TestMethod]
        public void OnlyOneBracketFacingOutwardsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }
        [TestMethod]
        public void LaunchCodeWithBracketsFacingWrognDirectionReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code["));
        }
    }

}
