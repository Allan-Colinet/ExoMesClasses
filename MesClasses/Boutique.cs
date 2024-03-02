using MesClasses;
using RPG.Loot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Boutique
    {
        public static void AfficherBoutique(List<Equipement>Equipements)
        {
            Console.WriteLine($"Bienvenue dans la boutique du jeu");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Voici la liste des items que vous pouvez acheter");
            foreach (Equipement listShop in Equipements)
            {
                Console.WriteLine($"{listShop.nom} prix : {listShop.prix} Or");
            }
        }
    }
}
