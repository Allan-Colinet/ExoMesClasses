using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Loot
{
    public class Consommable : Equipement
    { 
        // La méthode sera à implémenté avec le système de combat
        Random rnd = new Random();
        
        public int Soin(int nbFaces, int nbDes)
        {
            return 0;//(nbFaces, nbDes);
        }
    }
}
