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
            Assert.AreEqual( "Giocatori: Pippo", message, "Add new Player Failed");
        }

        /// <summary>
        /// aggiunta giocatore Se non c’è nessun partecipante L’utente sceglie “aggiungi giocatore Pippo” Il sistema risponde: “Giocatori: Pippo” 
        /// </summary>
        [TestMethod]
        public void ExistingPlayerAddNewPlayer()
        {
            Game game = new Game();
            game.AddPlayer("Pippo");
            var message = game.AddPlayer("Pluto");
            Assert.AreEqual("Giocatori: Pippo, Pluto", message, "Add second Player Failed");
        }

        /// <summary>
        /// giocatore duplicato Se c’è già un partecipante “Pippo” L’utente sceglie “aggiungi giocatore Pippo” Il sistema risponde: “Pippo: giocatore già presente”
        /// </summary>
        [TestMethod]
        public void AddExistingPlayer()
        {
            var giocatore = "Pippo";
            var game = NewGameWithPlayer(giocatore);
            var message = game.AddPlayer(giocatore);
            Assert.AreEqual("Pippo: giocatore gia' presente", message, "Add existing Player Failed");
        }

       

        [TestMethod]
        public void MovePlayerPippoFromStart()
        {
            var giocatore = "Pippo";
            var game = NewGameWithPlayer(giocatore);
            var message = game.Move ("Pippo", 4,2);
            Assert.AreEqual("Pippo tira 4, 2. Pippo muove da Partenza a 6", message, "Move Player 4,2 From Start Failed");
        }

        [TestMethod]
        public void MovePlayerPlutoFromStart()
        {
            var giocatore = "Pluto";
            var game = NewGameWithPlayer(giocatore);
            var message = game.Move("Pluto", 2, 2);
            Assert.AreEqual("Pluto tira 2, 2. Pluto muove da Partenza a 4", message, "Move Player 2,2 From Start Failed");
        }

        [TestMethod]
        public void MovePlayerPippoFromNonStart()
        {
            var giocatore = "Pippo";
            var game = NewGameWithPlayer(giocatore);
            game.Move(giocatore, 4, 2);
            var message = game.Move(giocatore, 2, 3);
            Assert.AreEqual("Pippo tira 2, 3. Pippo muove da 6 a 11", message, "Move Player From Not Start Failed");
        }

        [TestMethod]
        public void MovePlayerWithAutoRoller1_2()
        {
            var giocatore = "Pippo";
            MockDiceRoller dr = new MockDiceRoller(1,2);
            var game = NewGameWithPlayer(giocatore, dr);
            game.Move(giocatore, 4, 0);
            var message = game.Move(giocatore);
            Assert.AreEqual("Pippo tira 1, 2. Pippo muove da 4 a 7", message, "Move Player From Not Start Failed");
        }


        [TestMethod]
        public void MovePlayerWithAutoRoller1_1()
        {
            var giocatore = "Pippo";
            MockDiceRoller dr = new MockDiceRoller(1, 1);
            Game game = new Game(dr);
            game.AddPlayer(giocatore);
            game.Move(giocatore, 4, 0);
            var message = game.Move(giocatore);
            Assert.AreEqual("Pippo tira 1, 1. Pippo muove da 4 a 6", message, "Move Player With automatic Dice Rolling Failed");
        }

        [TestMethod]
        public void MovePippoTo63()
        {
            Game game = new Game();
            var giocatore = "Pippo";
            game.AddPlayer(giocatore);
            game.Move(giocatore, 60, 1);
            var message = game.Move(giocatore, 1, 1);
            Assert.AreEqual("Pippo vince!!", message, "Move Pippo To last Tile Failed");
        }

        [TestMethod]
        public void MovePlutoTo63()
        {
            var giocatore = "Pluto";
            Game game = new Game();
            game.AddPlayer(giocatore);
            var message = game.Move(giocatore, 63, 0);
            Assert.AreEqual("Pluto vince!!", "Move Pippo To last Tile Failed");
        }

        private static Game NewGameWithPlayer(string giocatore)
        {
            Game game = new Game();
            game.AddPlayer(giocatore);
            return game;
        }

        private static Game NewGameWithPlayer(string giocatore, MockDiceRoller dr)
        {
            Game game = new Game(dr);
            game.AddPlayer(giocatore);
            return game;
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
