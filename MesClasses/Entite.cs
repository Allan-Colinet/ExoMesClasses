using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public abstract class Entite
    {
        // Ici toutes les class qui vont hérité de Entite auront un NomPerso une méthode Creation et AfficherCaracteristiques
        public string? NomPerso { get; set; }
        #region Caracteristiques
        // le protected permet d'être utiliser dans la pile d'héritage pas autre part, contrairement au private
        public int MaxPV { get; set; }

        protected int _pv;
        public int Pv
        {
            get { return _pv + Modificateur(Endurance); }
            set { _pv = value; }
        }
        protected int _force;
        public virtual int Force
        {
            get { return _force ; }
            set { _force = value; }
        }
        protected int _endurance;
        public virtual int Endurance
        {
            get { return _endurance ; }
            set { _endurance = value; }
        }
        #endregion
        public abstract void Creation();
        
        public abstract void AfficherCaracteristique();
        public static int Modificateur(int stats)
        {
            if (stats < 10)
            {
                return - 1;
            }
            else if (stats < 13)
            {
                return 0;
            }
            else if(stats < 16)
            {
                return 1;
            }
            else if(stats < 19)
            {
                return 2;
            }
            else if (stats < 22)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }
    }
}
