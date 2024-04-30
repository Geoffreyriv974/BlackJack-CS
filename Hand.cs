using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Hand
    {

        private List<Card> HandCard = new List<Card>();

        public void AddCard(Card card) 
        {
            HandCard.Add(card);
        }

        public void ViewCard()
        {
            Console.WriteLine("\n-----------------");
            Console.WriteLine("Cartes dans la main :");
            foreach (Card item in HandCard)
            {
                Console.WriteLine("\n" + item.Val + " de " + item.Typ);
            }
            Console.WriteLine("-----------------\n");
        }

    }
}
