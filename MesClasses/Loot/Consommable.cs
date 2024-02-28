using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Loot
{
    public class Consommable : Equipements
    { 
        Random rnd = new Random();
        Consommable PotionSoin = new Consommable();
        

        public int ConsommableEffet()
        {
            return (rnd.Next(1, 5) + rnd.Next(1, 5));
        }
    }
}
