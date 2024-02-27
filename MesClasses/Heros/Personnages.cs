using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses.Heros
{
    public class Personnages
    {
        //public override/virtual type nom
        //{
        //get { }
        // set { }
        //}
        #region Perso
        public string? NomPerso { get; set; }

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
            get { return _intelligence; }
            set { _intelligence = value; }
        }
        private int _sagesse;
        public virtual int Sagesse
        {
            get { return _sagesse; }
            set { _sagesse = value; }
        }
        // avec le _xxx c'est la valeur de base avec Maj valeur + bonus
        //public void ChoixClasse()
        //{


        public void NewPerso()
        {
            Console.WriteLine("Choisissez votre pseudo :");
            NomPerso = Console.ReadLine();

            Random rnd = new Random();
            Force = rnd.Next(10, 21);
            Endurance = rnd.Next(10, 21);
            Intelligence = rnd.Next(10, 21);
            Sagesse = rnd.Next(10, 21);

            AfficherStat();
        }

        public void AfficherStat()
        {
            Console.WriteLine($"{NomPerso} vous êtes un {GetType().Name}, bonne chance dans cette aventure");
            Console.WriteLine();
            Console.WriteLine($"Vous obtenez les caractéristiques suivante :");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Force : " + (GetType().Name == "Guerrier" ? _force + " + " + (Force - _force) + " = " + Force : Force));
            Console.WriteLine("Endurance : " + (GetType().Name == "Guerrier" ? _endurance + " + " + (Endurance - _endurance) + " = " + Endurance: Endurance));
            if (GetType().Name == "Mage")
            {
                Console.WriteLine("Intelligence : " + (GetType().Name == "Mage" ? _intelligence + " + " + (Intelligence - _intelligence)+ " = "+ Intelligence : Intelligence));
            }
            else if (GetType().Name == "Pretre")
            {
                Console.WriteLine("Intelligence : " + (GetType().Name == "Pretre" ? _intelligence + " + " + (Intelligence - _intelligence) + " = " + Intelligence : Intelligence));
            }
            else { Console.WriteLine($"Intelligence : {Intelligence}"); }

            if (GetType().Name == "Mage")
            {
                Console.WriteLine("Sagesse : " + (GetType().Name == "Mage" ? _sagesse + " + " + (Sagesse - _sagesse) + " = " + Sagesse : Sagesse));
            }
            else if (GetType().Name == "Pretre")
            {
                Console.WriteLine("Sagesse : " + (GetType().Name == "Pretre" ? _sagesse + " + " + (Sagesse - _sagesse) + " = " + Sagesse : Sagesse));
            }
            else { Console.WriteLine($"Sagesse : {Sagesse}"); }
            Console.WriteLine();
        }
        #endregion
    }

}

