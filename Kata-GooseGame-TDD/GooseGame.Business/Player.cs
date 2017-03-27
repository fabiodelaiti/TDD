namespace GooseGame.Business
{
    public class Player
    {
        public Player(string name)
        {
            Name = name;
        }

        public string Name { get; internal set; }
        public int Position { get; internal set; }
        public object PositionName
        {
            get
            {
                var strPos = "Partenza";
                if (Position != 0)
                    strPos =  Position.ToString();
                return strPos;
            }
        }
    }
}