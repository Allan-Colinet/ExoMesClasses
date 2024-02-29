using RPG;
using RPG.Loot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MesClasses.Monstres
{
    public class Monstre : Entite
    {
        
        // méthode pour créer un monstre en override en lien avec se qui se trouve dans Entite pareil pour les caractéristiques
        public override void Creation()
        {
            Random rnd = new Random();
            Force = rnd.Next(10, 21);
            Endurance = rnd.Next(10, 21);
        }

        public override void AfficherCaracteristique()
        {
            Console.WriteLine(this.GetType().Name);
            if (this.GetType().Name == "Gobelin")
            {
                Console.WriteLine($"Force : {_force} {Force - _force} = {Force}");
                Console.WriteLine($"Endu : {Endurance}");
            }
            else
            {
                Console.WriteLine($"Force : {_force} + {Force - _force} = {Force}");
                Console.WriteLine($"Endu : {_endurance} + {Endurance - _endurance} = {Endurance}");
            }
        }
    }
}
