using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses
{
    public class Orc : Monstres
    {
        public override int Force { get => base.Force+3; set => base.Force = value; }
        public override int Endurance { get => base.Endurance+2; set => base.Endurance = value; }

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
