using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses
{
    public class Pretre
    {
        public string NomPerso { get; set; }


        private int _force;
        public int Force
        {
            get { return _force; }
            set { _force = value; }
        }

        private int _endurance;
        public int Endurance
        {
            get { return _endurance; }
            set { _endurance = value; }
        }
        private int _intelligence;
        public int Intelligence
        {
            get { return _intelligence+2; }
            set { _intelligence = value; }
        }
        private int _sagesse;
        public int Sagesse
        {
            get { return _sagesse+4; }
            set { _sagesse = value; }
        }


        public void NewPerso()
        {
            Console.WriteLine("Choisissez votre pseudo :");
            NomPerso = Console.ReadLine();

            Random rnd = new Random();
            Force = rnd.Next(10, 21);
            Endurance = rnd.Next(10, 21);
            Intelligence = rnd.Next(10, 21);
            Sagesse = rnd.Next(10, 21);
        }
    }
}
