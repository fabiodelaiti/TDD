using GooseGame.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GooseGame.Console;

namespace GooseGame.Tests
{
    [TestClass]
    public class CommanderTests
    {
        Commander _commander = null;
        MockGame _mockGame = null;

        [TestInitialize]
        public void Init()
        {
            var roller = new DiceRoller();
            _mockGame = new MockGame();
            _commander = new Commander(_mockGame);
        }

        [TestMethod]
        public void AggiungiGocatoreCallsGameAdd()
        {
            _commander.Do("aggiungi giocatore Pippo");
            Assert.AreEqual("AddPippo",((MockGame)_mockGame).Verification);
        }

        [TestMethod]
        public void MuoviGocatoreconLanciCallsGameMoveConLanci()
        {

            _commander.Do("muovi Pippo 4, 2");
            Assert.AreEqual("MovePippo42", ((MockGame)_mockGame).Verification);
        }

        [TestMethod]
        public void MuoviGocatoreCallsGameMove()
        {
            _commander.Do("muovi Pippo");
            Assert.AreEqual("MovePippo", ((MockGame)_mockGame).Verification);
        }

        [TestMethod]
        public void MuoviSoloDado()
        {
            Assert.AreEqual("Istruzione non riconosciuta", _commander.Do("muovi Pippo 1"));
        }

        [TestMethod]
        public void AggiungiSenzaGiocatore()
        {
            Assert.AreEqual("Istruzione non riconosciuta", _commander.Do("aggiungi Pippo"));
        }
    }

   

    public class MockGame : IGooseGame
    {
       
        public MockGame()
        {
           
        }
        public string Verification { get; set; }
        public string AddPlayer(string name)
        {
            Verification = "Add" + name;
            return null;
        }

        public string Move(string name)
        {
            Verification = "Move" + name;
            return null;
        }

        public string Move(string name, int lancio1, int lancio2)
        {
            Verification = $"Move{name}{lancio1}{lancio2}";
            return null;
        }
    }
}
