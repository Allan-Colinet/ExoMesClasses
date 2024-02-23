using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses
{
    internal class Pretre
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
            get { return _intelligence; }
            set { _intelligence = value+2; }
        }
        private int _sagesse;
        public int Sagesse
        {
            get { return _sagesse; }
            set { _sagesse = value+4; }
        }


        public void NewStats()
        {
            Random rnd = new Random();
            _force = rnd.Next(10, 21);
            _endurance = rnd.Next(10, 21);
            _intelligence = rnd.Next(10, 21);
            _sagesse = rnd.Next(10, 21);
        }
    }
}
