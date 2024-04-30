using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Croupier
    {
        public void Appel()
        {
            Card drawCard = Sabot.GetInstance().Draw();

            Console.WriteLine("\n***Le Croupier a reçu une carte : " + drawCard.Val + " de " + drawCard.Typ + "***");
        }
    }
}
