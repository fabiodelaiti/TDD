namespace GooseGame.Business
{
    public interface IGooseGame
    {
        string AddPlayer(string name);
        string Move(string name);
        string Move(string name, int lancio1, int lancio2);
    }
}