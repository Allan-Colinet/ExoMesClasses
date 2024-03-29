﻿using MesClasses.Heros;
using RPG.Loot;

namespace MesClasses
{
    public class Program
    {
        // clic droit sur la méthode (après avoir fait une modification entrainant des erreurs) hierarchie d'appels et aller corriger aux endroits ou la méthode est utilisée
        //Personnage joueur;
        static void Main(string[] args)
        {
            //Initialisation de la partie et des méthodes nécessaires au fonctionnement du jeu avec des affichages pour s'assurer que tout ce qui est déjà implémenté fonctionne
            Jeu partie = new Jeu();
            partie.InitialiserEquipements();
            partie.ChoixClasse();
            partie.GenererHorde();
            partie.AfficherHorde();
            Console.WriteLine();
            partie.UtiliserBoutique();
        }
    }
}
