using RPG.Loot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses.Monstres.Monstres
{
    public class Gobelin : Monstre, IInventaire
    {
        List<Equipements> equipementsGobelin = new List<Equipements>();
        
        //Voir commentaire dans Orc
        
        public override int Force { get => base.Force - 1; set => base.Force = value; }
        public List<Equipements> ContenuInventaire { get ; set ; }

        public void CoupDeMasse()
        {
            Console.WriteLine("Je tappe à la masse !");
        }
    }
}