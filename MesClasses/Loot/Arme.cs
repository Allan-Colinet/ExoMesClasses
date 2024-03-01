using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Loot
{
    // la classe Arme hérite d'équipement, ici les propriétés nbFaces et nbDes permettent d'utiliser le lancé de dés pour le calcul des stats des armes
    public class Arme : Equipement
    {
        
        public int nbFaces {  get; set; }

        public int nbDes {  get; set; }

        Random rnd = new Random();
        
        // La méthode dégats sera implémentée par après avec le système de combats
        public int Degats()
        {
            return rnd.Next(1,nbFaces + 1);
        }

    }
}
