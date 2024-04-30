using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Croupier
    {

        Hand croupierHand = new Hand();

        public void Appel()
        {
            Card drawCard = Sabot.GetInstance().Draw();
            croupierHand.AddCard(drawCard);

            Console.WriteLine("\n***Le Croupier a reçu une carte : " + drawCard.Val + " de " + drawCard.Typ + "***");

            croupierHand.ViewCard();
        }

        public void Play()
        {
            while (croupierHand.Score < 17) 
            {
                Appel();
            }

        }

    }
}
