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

            Console.WriteLine();
            Console.WriteLine($"Bonjour, {userName}! Je m'appelle Geoffrey, je serai le Croupier lors de cette partie!");

            Sabot.GetInstance().InitSabot(6);

            string start = "";

            while (start != "yes" && start != "no")
            {
                Console.WriteLine();
                Console.Write("Voulez vous commencer une partie ? (yes/no)");
                start = Console.ReadLine();

                if (start == "yes")
                {
                    Console.WriteLine();
                    Console.WriteLine("Je vais tout d'abord distribuer les cartes!");

                    Player player = new Player();
                    player.Appel();

                    Croupier croupier = new Croupier();
                    croupier.Appel();

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
            
        }

    }
}
 