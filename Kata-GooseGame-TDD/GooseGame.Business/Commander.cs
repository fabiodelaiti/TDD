using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooseGame.Business
{
    public class Commander
    {
        IGooseGame _game;
        public Commander(IGooseGame game)
        {
            _game = game;
        }

        public string Do(string input)
        {
            if (input.StartsWith("aggiungi giocatore"))
            {
                var nomeGiocatore = input.Substring("aggiungi giocatore".Length).TrimStart();
                return _game.AddPlayer(nomeGiocatore);

            }
            if (input.StartsWith("muovi"))
            {
                var nomeGiocatoreConLanci = input.Substring("muovi".Length).TrimStart();
                var tokens = nomeGiocatoreConLanci.Split(' ',',');
                if (tokens.Length ==1)
                    return _game.Move(tokens[0]);

                return _game.Move(tokens[0], int.Parse(tokens[1]),int.Parse(tokens[3]));

            }
            return null;
        }
    }
}
