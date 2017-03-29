using GooseGame.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooseGame.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            var commander = new Commander(game);
            while (true)
            {
                var input = System.Console.ReadLine();
                var ret = commander.Istruzione(input);
                System.Console.WriteLine(ret);
              
            }
        }
    }
}
