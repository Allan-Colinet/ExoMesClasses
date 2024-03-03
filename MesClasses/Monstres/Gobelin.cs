using RPG.Loot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses.Monstres.Monstres
{
    public class Gobelin : Monstre, IInventaire, IOr
    {
        //Ajouter loot rnd(0,3) sur liste Equipements à l'intanciation avec une méthode
        public int Or { get; set; }
        public override void Creation()
        {
            Inventaire = new List<Equipement>();
            Random rnd = new Random();
            base.Creation();
            Or = rnd.Next(1, 7);
        }
        public override int Force { get => base.Force - 1; set => base.Force = value; }
        public void AfficherLootGobelin()
        {
            foreach (Equipement item in Inventaire)
            {
                Console.WriteLine(item.nom);
            }
        }
        public void CoupDeMasse()
        {
            Console.WriteLine("Je tappe à la masse !");
        }
    }
}