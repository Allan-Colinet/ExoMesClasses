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
            Random rnd = new Random();
            base.Creation();
            Or = rnd.Next(1, 7);
        }
        public override int Force { get => base.Force - 1; set => base.Force = value; }
        public List<Equipement> Inventaire { get; set; }
        public void CoupDeMasse()
        {
            Console.WriteLine("Je tappe à la masse !");
        }
    }
}