﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses.Heros
{
    public class Guerrier : Personnage
    {
        public override int Endurance { get => base.Endurance + 3; set => base.Endurance = value; }
        public override int Force { get => base.Force + 3; set => base.Force = value; }

        
    }
}
