using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Loot
{
    public class Armure : Equipement
    {
        // toutes les armures ont une propriété de réduction de degats La méthode sera mise à jour à l'implémentation du système de combats
        public int Armures { get; set; }
        public int ReducDegats { get; set; }
    }
}
