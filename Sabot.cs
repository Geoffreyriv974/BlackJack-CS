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
    public sealed class Sabot
    {
        private static Sabot _instance;

        private Random random = new Random();
        private List<Card> Cards = new List<Card>();

        public static Sabot GetInstance()
        {
            if (_instance == null)
                _instance = new Sabot();
            return _instance;
        }

        public void InitSabot(int NumberDeck)
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
                }
            }

        }

    }
}
