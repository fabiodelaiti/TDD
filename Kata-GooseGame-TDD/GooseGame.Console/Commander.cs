using GooseGame.Business;

namespace GooseGame.Console
{
    public class Commander
    {
        IGooseGame _game;
        public Commander(IGooseGame game)
        {
            _game = game;
        }

        public string Istruzione(string input)
        {
            if (input.StartsWith("aggiungi giocatore"))
            {
                var nomeGiocatore = input.Substring("aggiungi giocatore".Length).TrimStart();
                return _game.AddPlayer(nomeGiocatore);

            }
            if (input.StartsWith("muovi"))
            {
                var nomeGiocatoreConLanci = input.Substring("muovi".Length).TrimStart();
                var regEx = new System.Text.RegularExpressions.Regex(@"(?<name>[a-zA-Z]+)|(?<dice>[\d])");
                var matches = regEx.Matches(nomeGiocatoreConLanci);
             
                if (matches.Count==3)
                    return _game.Move(matches[0].Value, int.Parse(matches[1].Value),int.Parse(matches[2].Value));
                if (matches.Count == 1)
                    return _game.Move(matches[0].Value);

            }
           
            return "Istruzione non riconosciuta";
        }
    }
}
