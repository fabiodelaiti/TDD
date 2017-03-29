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
            Regex r = null;

            r = new Regex(@"(?<name>[a-zA-Z]+)|(?<Dice>[\d])");
            var matches = r.Matches(str);
            Assert.AreEqual("Nome",  matches[0].Value, "RegEx doesen't match Name");
            Assert.AreEqual("5", matches[1].Value, "RegEx doesen't match first Dice");
            Assert.AreEqual("1", matches[2].Value, "RegEx doesen't match second Dice");

        }
    }
}
