using RPG.Loot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses.Monstres
{
    public class Orc : Monstre, IOr
    {

        public int Or { get ; set; }
        public override void Creation()
        {
            Inventaire = new List<Equipement>();
            Random rnd = new Random();
            base.Creation();
            Or = rnd.Next(2, 7);
        }
        public void AfficherLootOrc()
        {
            foreach (Equipement item in Inventaire)
            {
                Console.WriteLine(item.nom);
            }
        }
        // instanciation du bonus Force pour cette classe en override car les paramètres sont en protected et c'est la condition pour utiliser le paramètre protected d'un parent
        public override int Force { get => base.Force + 3; set => base.Force = value; }
        public override int Endurance { get => base.Endurance + 2; set => base.Endurance = value; }
        //Méthode propre à l'orc
        public void CoupDeHache()
        {
            Console.WriteLine("Attention au coup de hache !");
        }
        public void CriDeGuerre()
        {
            Console.WriteLine("Encore du travail");
        }
    }
}
