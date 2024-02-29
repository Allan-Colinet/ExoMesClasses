using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Loot
{
    public abstract class Equipements
    {
        //Ici j'ai choisi une classe abstract pour que toutes les class qui vont hérité d'Equipements doivent instancié les paramètres de la classe abstract (nom, prix, nbFaces, nbDes)
        public string nom {  get; set; }
        public int prix { get; set; }
        public int nbFaces { get; set; }
        public int nbDes { get; set; }

    }

    
}
