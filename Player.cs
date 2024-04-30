using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Player
    {

        public void Appel()
        {
            Card drawCard = Sabot.GetInstance().Draw();

            Console.WriteLine();
            Console.WriteLine("Vous avez reçu une carte : " + drawCard.Val + " de " + drawCard.Typ);
            Console.WriteLine();
        }

    }
}
