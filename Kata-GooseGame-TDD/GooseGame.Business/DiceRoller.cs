using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooseGame.Business
{
    public class DiceRoller
    {
        public virtual int[] Roll()
        {
            System.Random rnd = new Random();
            return new[] { rnd.Next(1, 7), rnd.Next(1, 7) };
            }
    }
}
