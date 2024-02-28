using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public static class De
    {
        public static int Lancer(int nbDes, int nbFaces )
        {
            Random rnd = new Random();

            int resultLancerMultiple = 0;
            for (int i = 0; i < nbDes; i++)
            {
            resultLancerMultiple += rnd.Next(1, nbFaces+1);
            }
            return resultLancerMultiple;
        }
    }
}
