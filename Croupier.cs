using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Croupier
    {

        Hand playerHand = new Hand();

        public Croupier() 
        {
            Hand playerHand = new Hand();
        }

        public void Appel()
        {
            Card drawCard = Sabot.GetInstance().Draw();
            playerHand.AddCard(drawCard);

            Console.WriteLine("\n***Le Croupier a reçu une carte : " + drawCard.Val + " de " + drawCard.Typ + "***");

            playerHand.ViewCard();
        }

        public void Play()
        {
            while (playerHand.Score < 17) 
            {
                Appel();
            }
        }

    }
}
