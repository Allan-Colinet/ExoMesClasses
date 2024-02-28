using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Loot
{
    public class Arme : Equipements
    {
        private int _nbFaces;
        public virtual int NbFace
        {
            get { return _nbFaces; }
            set { _nbFaces = value; }
        }

        Random rnd = new Random();
        
        public int Degats()
        {
            return rnd.Next(1,_nbFaces + 1);
        }

    }
}
