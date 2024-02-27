using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses.Monstres.Monstres
{
    public class Loup : Monstres
    {
        public override int Force { get => base.Force + 2; set => base.Force = value; }
        public override int Endurance { get => base.Endurance + 1; set => base.Endurance = value; }
        public void Morsure()
        {
            Console.WriteLine("Je mords");
        }
        public void Hurlement()
        {
            Console.WriteLine("J'hurle ! haou!!!");
        }
    }
}
