using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GooseGame.Tests
{
    [TestClass]
    public class PocTests
    {
        [TestMethod]
        public void PocRegEx()
        {
            var str = "Nome 5, 1";
            System.Text.RegularExpressions.Regex r = null;

            r = new System.Text.RegularExpressions.Regex(@"(?<name>[a-zA-Z]+)|(?<Dice>[\d])");
            var matches = r.Matches(str);
            Assert.AreEqual("Nome",  matches[0].Value);
            Assert.AreEqual("5", matches[1].Value);
            Assert.AreEqual("1", matches[2].Value);

        }
    }
}
