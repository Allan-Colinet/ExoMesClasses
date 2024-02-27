using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses.Monstres
{
    public class Monstres
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

    }
}
