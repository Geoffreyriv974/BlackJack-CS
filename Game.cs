using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BlackJack.Card;

namespace BlackJack
{
    public class Game
    {

        public void Run()
        {
            Sabot sabot = new Sabot(6);
            sabot.Fill();
        }

    }
}
 