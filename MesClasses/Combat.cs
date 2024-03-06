using MesClasses.Heros;
using MesClasses.Monstres;
using RPG.Loot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Combat
    // Pour le combat il faut quoi ? Monstre et Perso
    //instancier private Personnage joueur; même pour monstre
    // clic droit sur la class et générer ctor (si c'est en private)
    {
        private Personnage _joueur;
        private Monstre _monstre;

        public Combat(Personnage joueur, Monstre monstre)
        {
            _joueur = joueur;
            _monstre = monstre;
        }

        // créer une méthode de choix Arme

        private Arme ChoixArme()
        {
            Console.WriteLine("Avec quelle arme voulez-vous vous battre ?");
            // méthode linQ tu instancie une liste "armes"(nom parametres) qui correspond à l'inventaire du hero où "equipement"(nom de parametre à choisir) + => expression lambda pour demander si equipement est une arme et en faire une liste avec le ToList 
            //List<Equipement> armes = _joueur.InventaireHero.Where(equipement => equipement is Arme).ToList();
            List<Arme> armes = new List<Arme>();
            foreach (Equipement e in _joueur.InventaireHero)
            {
                if (e is Arme)
                {
                    armes.Add((Arme)e);
                }
            }
            for (int i = 0; i < armes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {armes[i].nom}");
            }
            int choix = int.Parse(Console.ReadLine());
            return armes[choix - 1];
        }

        private int CalculReduction()
        {
            List<Armure> armure = new List<Armure>();
            foreach(Equipement item in _joueur.InventaireHero)
            {
                if (item is Armure)
                {
                    armure.Add((Armure)item);
                }
            }
            return armure.Max(armure => armure.ReducDegats);
        }
        public void DebuterCombat()
        {
            Entite attaquant = _joueur;
            while (_joueur.Pv > 0 && _monstre.Pv > 0)
            {
                Arme arme = null;
                if (attaquant is Personnage)
                {
                    arme = ChoixArme();
                    int degat = arme.Degats() + Entite.Modificateur(_joueur.Force);
                    _monstre.Pv -= degat;
                    attaquant = _monstre;
                    Console.WriteLine($"Le héro à fait {degat}");
                }
            }
        }


        //créer méthode pour le combat InfligerDegats (utilisation de l'arme pour taper et reduction de l'armure)
    }
}

