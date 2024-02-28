using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Loot
{
    public abstract class Equipements
    {
        public string nom {  get; set; }
        protected int prix { get; private set; }
    }
}
