using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooseGame.Business
{
    public class Game : IGooseGame
    {
        private List<Player> _players;
        private DiceRoller _dr;


        public Game():this(new DiceRoller())
        {
           
        }

        public Game(DiceRoller dr)
        {
            _dr = dr;
            _players = new List<Player>();
        }

        public string AddPlayer(string name)
        {
            if(_players.Exists(p=> p.Name == name))
                return $"{name}: giocatore gia' presente";
            _players.Add(new Player(name));

            return $"Giocatori: {string.Join(", ", _players.Select(p=>p.Name))}";
        }

        public string Move(string name, int lancio1, int lancio2)
        {
            var player = _players.Single(p => p.Name==name);
            var previousPosition = player.PositionName;
            player.Position += (lancio1 + lancio2);
            if (player.Position >= 63)
                return $"{player.Name} vince!!";
            return $"{player.Name} tira {lancio1}, {lancio2}. {player.Name} muove da {previousPosition} a {player.Position}";
        }

        public string Move(string name)
        {
            var roll = _dr.Roll();
            int lancio1 = roll[0];
            int lancio2 = roll[1];
            return Move(name, lancio1, lancio2);
        }
    }
}
