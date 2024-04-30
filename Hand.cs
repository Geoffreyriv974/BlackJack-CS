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
        private Hand playerHand;
        private Hand croupierHand;

        public Hand()
        {

        }

        public void sort() 
        {
            HandCard.Sort((x, y) =>
            {
                if (x.Val == Card.Value.As && y.Val != Card.Value.As)
                    return 1;
                else if (x.Val != Card.Value.As && y.Val == Card.Value.As)
                    return -1;
                else
                    return 0;
            });
        }

        public int Score
        {
            get
            {
                int addScore = 0;

                foreach (Card item in HandCard)
                {

                    if (item.Val == Card.Value.As && addScore + 11 > 21)
                    {
                        addScore += 1;
                    }
                    else
                    {
                        addScore += (int)item.Val;
                    }
                }

                return addScore;
            }
        }

        public void AddCard(Card card) 
        {
            HandCard.Add(card);
        }

        public void ViewCard()
        {
            Console.WriteLine("\n-----------------");
            Console.WriteLine("Cartes dans la main :");
            sort();
            foreach (Card item in HandCard)
            {
                Console.WriteLine("\n" + item.Val + " de " + item.Typ);
            }
            Console.WriteLine("\nScore : " + this.Score);
            Console.WriteLine("-----------------\n");
        }

    }
}
