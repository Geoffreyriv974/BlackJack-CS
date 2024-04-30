using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BlackJack.Card;

namespace BlackJack
{
    internal class Sabot
    {

        private Random random = new Random();
        public List<Card> Cards = new List<Card>();


        public Sabot(int NumberDeck)
        {
            
            for (int i = 1; i < NumberDeck; i++)
            {
                Fill();
            }

        }


        public Card Draw()
        {

            if (Cards.Count == 0)
            {
                Console.WriteLine("Il n'y a plus de carte disponible !");
                return null;
            }
            else
            {
                int randomCard = random.Next(0, Cards.Count);

                Card drawCard = Cards[randomCard];
                Cards.RemoveAt(randomCard);

                Console.WriteLine("Vous avez pioché une carte : " + drawCard.Val +  " de " + drawCard.Typ);

                return drawCard;
            }

        }

        public void Fill()
        {
            foreach (Value value in Enum.GetValues(typeof(Value)))
            {
                foreach(Types type in Enum.GetValues(typeof(Types)))
                {
                    Card card = new Card(value, type); 
                    Cards.Add(card);
                    Console.WriteLine(card.Val + " de " + card.Typ);
                }
            }

        }

    }
}
