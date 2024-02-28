using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Loot
{
    public class Arme : Equipements
    {
        
        public int nbFaces {  get; set; }

        public int nbDes {  get; set; }

        Random rnd = new Random();
        
        public int Degats()
        {
            return rnd.Next(1,nbFaces + 1);
        }

    }
}
