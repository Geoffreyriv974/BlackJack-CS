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
        Hand hand = new Hand();
        
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
                Console.Write("\nVoulez vous commencer une partie ? (yes/no) ");
                start = Console.ReadLine();

                if (start == "yes")
                {
                    PuttingCredit();

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

            player.ShowCredit();

            string stringPutting = "";
            int putting;

            do
            {

                Console.Write("Combien de crédit voulez-vous miser ? ");
                stringPutting = Console.ReadLine();

                putting = int.Parse(stringPutting);

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
                    Console.WriteLine("\nVous avez misez un total de " + putting + " crédits");
                    Console.WriteLine("-----------------------------------------------------\n");

                    Distribution();
                }

            } while (putting == 0 && putting > player.Credit);

        }

        public void Distribution()
        {
            Console.WriteLine("\nJe vais tout d'abord distribuer les première cartes !");

            player.Appel();
            croupier.Appel();

            Continue();
        }

        public void Continue()
        {
            string before = "";

            while (before != "no")
            {

                Console.Write("\nVoulez-vous une nouvelle carte ? (yes/no) ");
                before = Console.ReadLine();

                if (before == "yes")
                {
                    player.Appel();
                }
                else if (before == "no")
                {
                    Console.WriteLine("\nD'accord");

                    Console.WriteLine("\nAu tour du Croupier de tirer !");

                    croupier.Play();
                }
                else
                {
                    Console.WriteLine("\nJe n'ai pas compris...");
                }
            }

            hand.CheckWinner();

        }

    }
}
 