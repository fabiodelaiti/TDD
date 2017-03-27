using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GooseGame.Business;
using System.Collections.Generic;
using System.Linq;
namespace GooseGame.Tests
{
    [TestClass]
    public class GameTests
    {
        /// <summary>
        /// aggiunta giocatore Se non c’è nessun partecipante L’utente sceglie “aggiungi giocatore Pippo” Il sistema risponde: “Giocatori: Pippo” 
        /// </summary>
        [TestMethod]
        public void NoPlayersAddPlayer()
        {
            Game game = new Game();
            var message  = game.AddPlayer("Pippo");
            Assert.AreEqual( "Giocatori: Pippo", message);
        }

        /// <summary>
        /// aggiunta giocatore Se non c’è nessun partecipante L’utente sceglie “aggiungi giocatore Pippo” Il sistema risponde: “Giocatori: Pippo” 
        /// </summary>
        [TestMethod]
        public void ExistingPlayersAddPlayer()
        {
            Game game = new Game();
            game.AddPlayer("Pippo");
            var message = game.AddPlayer("Pluto");
            Assert.AreEqual("Giocatori: Pippo, Pluto", message);
        }

        /// <summary>
        /// giocatore duplicato Se c’è già un partecipante “Pippo” L’utente sceglie “aggiungi giocatore Pippo” Il sistema risponde: “Pippo: giocatore già presente”
        /// </summary>
        [TestMethod]
        public void AddExistingPlayer()
        {
            Game game = new Game();
            game.AddPlayer("Pippo");
            var message = game.AddPlayer("Pippo");
            Assert.AreEqual("Pippo: giocatore gia' presente", message);
        }
       
        [TestMethod]
        public void MovePlayerPippoFromStart()
        {
            Game game = new Game();
            game.AddPlayer("Pippo");
            var message = game.Move ("Pippo", 4,2);
            Assert.AreEqual("Pippo tira 4, 2. Pippo muove da Partenza a 6", message);
        }

        [TestMethod]
        public void MovePlayerPlutoFromStart()
        {
            Game game = new Game();
            game.AddPlayer("Pluto");
            var message = game.Move("Pluto", 2, 2);
            Assert.AreEqual("Pluto tira 2, 2. Pluto muove da Partenza a 4", message);
        }

        [TestMethod]
        public void MovePlayerPippoFromNonStart()
        {
            Game game = new Game();
            game.AddPlayer("Pippo");
            game.Move("Pippo", 4, 2);
            var message = game.Move("Pippo", 2, 3);
            Assert.AreEqual("Pippo tira 2, 3. Pippo muove da 6 a 11", message);
        }

        [TestMethod]
        public void MovePlayerWithAutoRoller1_2()
        {
            MockDiceRoller dr = new MockDiceRoller(1,2);
            Game game = new Game(dr);
            game.AddPlayer("Pippo");
            game.Move("Pippo", 4, 0);
            var message = game.Move("Pippo");
            Assert.AreEqual("Pippo tira 1, 2. Pippo muove da 4 a 7", message);
        }

        [TestMethod]
        public void MovePlayerWithAutoRoller1_1()
        {
            MockDiceRoller dr = new MockDiceRoller(1, 1);
            Game game = new Game(dr);
            game.AddPlayer("Pippo");
            game.Move("Pippo", 4, 0);
            var message = game.Move("Pippo");
            Assert.AreEqual("Pippo tira 1, 1. Pippo muove da 4 a 6", message);
        }
     

        private class MockDiceRoller :DiceRoller
        {
            private int _lancio1;
            private int _lancio2;

            public MockDiceRoller(int lancio1, int lancio2)
            {
                this._lancio1 = lancio1;
                this._lancio2 = lancio2;
            }

            public override int[] Roll()
            {
                return new []{ _lancio1,_lancio2};
            }
        }

    }

   
}
