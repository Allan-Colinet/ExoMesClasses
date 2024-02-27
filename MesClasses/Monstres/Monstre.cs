using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MesClasses.Monstres
{
    public class Monstre
    {

        private int _endurance;
        public virtual int Endurance
        {
            get { return _endurance; }
            set { _endurance = value; }
        }

        private int _force;
        public virtual int Force
        {
            get { return _force; }
            set { _force = value; }
        }
        public void NewMonstre()
        {
            Random rn = new Random();
            Force = rn.Next(10, 21);
            Endurance = rn.Next(10, 21);
        }
        public void AfficherStatsMonstre()
        {
            Console.WriteLine(this.GetType().Name);
            if (this.GetType().Name == "Gobelin")
            {
                Console.WriteLine($"Force : {_force} {Force - _force} = {Force}");
                Console.WriteLine($"Endu : {Endurance}");
            }
            else if (this.GetType().Name == "Loup" || this.GetType().Name == "Orc")
            {
                Console.WriteLine($"Force : {_force} + {Force - _force} = {Force}");
                Console.WriteLine($"Endu : {_endurance} + {Endurance - _endurance} = {Endurance}");
            }
            
        }
    }
}
