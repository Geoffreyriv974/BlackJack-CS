using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static BlackJack.Card;

namespace BlackJack
{
    public class Game
    {

        Player player = new Player();
        Croupier croupier = new Croupier();

        public void Run()
        {

            Console.WriteLine("Bonjour, Bienvenus au BlackJack");

            Console.Write("Quel est votre nom ? ");
            string userName = Console.ReadLine();

            Console.WriteLine($"\nBonjour, {userName}! Je m'appelle Geoffrey, je serai le Croupier lors de cette partie!");

            Sabot.GetInstance().InitSabot(6);
            
            StartGame();

        }
        
        public void StartGame()
        {
            string start = "";

            while (start != "yes" && start != "no")
            {
                Console.Write("\nVoulez vous commencer une partie ? (yes/no)");
                start = Console.ReadLine();

                if (start == "yes")
                {
                    PuttingCredit();

                    player.Appel();
                    croupier.Appel();

                }
                else if (start == "no")
                {
                    Console.WriteLine("\nA bientôt");
                    return;
                }
                else
                {
                    Console.WriteLine("\nVous ne répondez pas a la question !");
                }
            }
        }


        public void PuttingCredit()
        {
            Console.WriteLine("\nJe vais tout d'abord distribuer les cartes!");

            player.ShowCredit();

            Console.WriteLine("Combien de crédit voulez-vous miser ? ");
            int putting = Console.Read();

            if (putting == 0)
            {
                Console.WriteLine("\nVous devez obligatoire misez des crédits !");
            }
            else if (putting > player.Credit)
            {
                Console.WriteLine("\nVous ne possédez pas asser de crédits !");
            }
            else
            {
                Console.WriteLine("\nJe n'ai pas compris...");
            }
        }


    }
}
 