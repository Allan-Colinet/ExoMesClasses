using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public static class De
    {
        //Utilisation d'une classe De (à voir si c'est pas mieux d'utiliser une interface) 

        //Cette méthode permet de lancer plusieurs dés selon le nombre voulu dans .nbDes = x;
        public static int Lancer(int nbDes, int nbFaces )
        {
            Random rnd = new Random();

            int resultLancer = 0;
            for (int i = 0; i < nbDes; i++)
            {
            resultLancer += rnd.Next(1, nbFaces+1);
            }
            return resultLancer;
        }
    }
}
