using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses.Monstres.Monstres
{
    public class Gobelin : Monstres
    {
        public override int Force { get => base.Force - 1; set => base.Force = value; }
        public void CoupDeMasse()
        {
            Console.WriteLine("Je tappe à la masse !");
        }
    }
}
