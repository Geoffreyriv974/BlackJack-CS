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
            Console.WriteLine("Bonjour, Bienvenus au BlackJack");

            Console.Write("Quel est votre nom ? ");
            string userName = Console.ReadLine();

            Console.WriteLine($"Bonjour, {userName}! Je m'appelle Geoffrey, je serai le Croupier lors de cette partie!");

            string start = "";

            while (start != "yes" && start != "no")
            {
                Console.Write("Voulez vous commencer une partie ? (yes/no)");
                start = Console.ReadLine();

                if (start == "yes")
                {
                    Console.WriteLine("1");
                }
                else if (start == "no")
                {
                    Console.WriteLine("A bientôt");
                    return;
                }
                else
                {
                    Console.WriteLine("Vous ne répondez pas a la question !");
                }
            }
            
            //Sabot sabot = new Sabot(6);
            //sabot.Fill();
        }

    }
}
 