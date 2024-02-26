using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses
{
    public class Personnages
    {
        //public override/virtual type nom
        //{
        //get { }
        // set { }
        //}
        public string NomPerso { get; set; }

        // private => ne pourra pas être modifié par l'utilisateur
        private int _force;

        // ici on va avoir la possibilité de le modifier
        // le get va retourner la variable à l'utilisateur. Ce sera une modification qui s'appliquera en plus de la variable (exemple d'un item qu'on peut mettre et retirer)
        // le set va modifier l'etat de la varibale (exemple d'un parchemin sur un rpg)
        public virtual int Force
        {
            get { return _force; }
            set { _force = value; }
        }

        private int _endurance;
        public virtual int Endurance
        {
            get { return _endurance; }
            set { _endurance = value; }
        }
        private int _intelligence;
        public virtual int Intelligence
        {
            get { return _intelligence ; }
            set { _intelligence = value; }
        }
        private int _sagesse;
        public virtual int Sagesse
        {
            get { return _sagesse ; }
            set { _sagesse = value; }
        }


        public virtual void NewPerso()
        {
            Console.WriteLine("Choisissez votre pseudo :");
            NomPerso = Console.ReadLine();

            Random rnd = new Random();
            Force = rnd.Next(10, 21);
            Endurance = rnd.Next(10, 21);
            Intelligence = rnd.Next(10, 21);
            Sagesse = rnd.Next(10, 21);
        }

        public void AfficherStat()
        {
            Console.WriteLine($"Vous êtes : {NomPerso}");
            Console.WriteLine($"Force : {Force}");
            Console.WriteLine($"Endurance : {Endurance}");
            Console.WriteLine($"Intelligence : {Intelligence}");
            Console.WriteLine($"Sagesse : {Sagesse}");
            Console.WriteLine();
        }
    }
}

