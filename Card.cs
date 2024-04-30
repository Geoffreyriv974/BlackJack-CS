using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Card
    {

        public Card(Value value, Types type)
        {
            this.Val = value;
            this.Typ = type;
        }

        public Value Val 
        { 
            get; set; 
        }

        public Types Typ 
        { 
            get; set; 
        }

        public enum Value
        {
            As = 1,
            Deux = 2,
            Trois = 3,
            Quatre = 4,
            Cinq = 5,
            Six = 6,
            Sept = 7,
            Huit = 8, 
            Neuf = 9,
            Dix = 10,
            Valet = 10,
            Dame = 10,
            Roi = 10,
        }

       public enum Types
        {
            Trefle,
            Carreaux,
            Pique,
            Coeur,
        }
    }
}
