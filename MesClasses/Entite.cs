using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public abstract class Entite
    {
        public string? NomPerso { get; set; }

        #region Caracteristiques
        // le protected permet d'être utiliser dans la pile d'héritage pas autre part, contrairement au private
        protected int _force;
        public virtual int Force
        {
            get { return _force; }
            set { _force = value; }
        }
        protected int _endurance;
        public virtual int Endurance
        {
            get { return _endurance; }
            set { _endurance = value; }
        }
        #endregion
        public abstract void Creation();
        public abstract void AfficherCaracteristique();
    }
}
