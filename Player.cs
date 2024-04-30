using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{

    public class Player
    {

        Hand playerHand = new Hand();
        public Player()
        {
            Credit = 1000;

        }

        public int Credit
        {
            get; set;
        }

        public void ShowCredit()
        {
            Console.WriteLine("\nVous possédez un total de " +  Credit + " crédits");
        }

        public void Appel()
        {
            Card drawCard = Sabot.GetInstance().Draw();
            playerHand.AddCard(drawCard);

            Console.WriteLine("\nVous avez reçu une carte : " + drawCard.Val + " de " + drawCard.Typ);

            playerHand.ViewCard();
        }

    }
}
