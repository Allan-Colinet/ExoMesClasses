using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Loot
{
    public class Armure : Equipements
    {
        // toutes les armures ont une propriété de réduction de degats
        public int Armures { get; set; }
        public int ReducDegats()
        { return /* Degats - */ Armures ; }
    }
}
