using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Card
    {

        public Card(Value value, Type type)
        {
            this.Val = value;
            this.Typ = type;
        }

        public Value Val 
        { 
            get; set; 
        }
        public Type Typ 
        { 
            get; set; 
        }

        public enum Value
        {
            As,
            Deux,
            Trois,
            Quatre,
            Cinq,
            Six,
            Sept,
            Huit, 
            Neuf,
            Dix,
            Valet,
            Dame,
            Roi,
        }

       public enum Type
        {
            Trefle,
            Carreaux,
            Pique,
            Coeur,
        }
    }
}
