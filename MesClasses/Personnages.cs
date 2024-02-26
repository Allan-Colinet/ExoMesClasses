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

        public virtual void AfficherStat()
        {
            Console.WriteLine($"{NomPerso} vous êtes un {this.GetType().Name}, bonne chance dans cette aventure");
            Console.WriteLine();
            Console.WriteLine($"Vous obtenez les caractéristiques suivante :");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Force : " + ((this.GetType().Name == "Guerrier") ? Force + " + " + (Force - _force) : Force ));
            Console.WriteLine("Endurance : " + ((this.GetType().Name == "Guerrier") ? Endurance + " + " + (Endurance - _endurance) : Endurance ));
            if (this.GetType().Name == "Mage")
            {
                Console.WriteLine("Intelligence : " + ((this.GetType().Name == "Mage") ? Intelligence + " + " + (Intelligence - _intelligence) : Intelligence));
            }
            else if (this.GetType().Name == "Pretre")
            {
                Console.WriteLine("Intelligence : " + ((this.GetType().Name == "Pretre") ? Intelligence + " + " + (Intelligence - _intelligence) : Intelligence));
            }
            else { Console.WriteLine($"Intelligence : {Intelligence}"); }

            if (this.GetType().Name == "Mage")
            {
                Console.WriteLine("Sagesse : " + ((this.GetType().Name == "Mage") ? Sagesse + " + " + (Sagesse - _sagesse) : Sagesse));
            }
            else if (this.GetType().Name == "Pretre")
            {
                Console.WriteLine("Sagesse : " + ((this.GetType().Name == "Pretre") ? Sagesse + " + " + (Sagesse - _sagesse) : Sagesse));
            }
            else { Console.WriteLine($"Sagesse : {Sagesse}"); }
            Console.WriteLine();
        }
    }
}

