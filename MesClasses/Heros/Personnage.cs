using RPG;
using RPG.Loot;
using System.Net;

namespace MesClasses.Heros
{
    public class Personnage : Entite, IInventaire, IOr
    {
        // La classe personnage à les propriétés propres aux héros (intelligence et sagesse)
        public List<Equipement> Inventaire { get ; set ; }
        //C'est un constructeur (ctor) pour l'inventaire du hero)
        public Personnage()
        {
            Inventaire = new List<Equipement>();
            
        }

        //public override/virtual type nom permet d'utiliser une méthode d'une classe parent ici les méthodes, objets, propriétés d'Entité et d'IInventaire(interface)
        //{
        //get { }
        // set { }
        //}
        #region Perso

        // ici on va avoir la possibilité de le modifier
        // le get va retourner la variable à l'utilisateur. Ce sera une modification qui s'appliquera en plus de la variable (exemple d'un item qu'on peut mettre et retirer)
        // le set va modifier l'etat de la varibale (exemple d'un parchemin sur un rpg)
        // private => ne pourra pas être modifié par l'utilisateur
        

       

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

        public int Or { get; set; }

        //Méthode pour la création des stats random du personnage choisi (sans les bonus du type de perso : Mage, pretre ou guerrier)
        public override void Creation()
        {
            Console.WriteLine("Choisissez votre pseudo :");
            NomPerso = Console.ReadLine();

            Random rnd = new Random();
            Force = rnd.Next(10, 21);
            Endurance = rnd.Next(10, 21);
            Intelligence = rnd.Next(10, 21);
            Sagesse = rnd.Next(10, 21);
            Pv = 10 ;
            Or = 100 ;
        }
        //public override int Endurance { get => base.Endurance + Modificateur(_endurance); set => base.Endurance = value; }

        //La méthode d'affichage des caractéristique des personnages selon l'affichage des bonus (le Force est la compétence+bonus et le _force la compétence sans le bonus)
        public override void AfficherCaracteristique()
        {
           
            Console.Clear();
            Console.WriteLine($"{NomPerso} vous êtes un {GetType().Name}, bonne chance dans cette aventure");
            Console.WriteLine();
            Console.WriteLine($"Vous obtenez les caractéristiques suivante :");
            Console.WriteLine("--------------------------------------------");
            // J'utilise une ternaire basée sur le type de personnage. Si la condition est un Guerrier alors tu écris ... ":" Sinon tu écris ...
            Console.WriteLine("Force : " + (GetType().Name == "Guerrier" ? _force + " + " + (Force - _force) + " = " + Force : Force));
            Console.WriteLine("Endurance : " + (GetType().Name == "Guerrier" ? _endurance + " + " + (Endurance - _endurance) + " = " + Endurance : Endurance));
            Console.WriteLine("Intelligence : " + (GetType().Name == "Mage" ? _intelligence + " + " + (Intelligence - _intelligence) + " = " + Intelligence : Intelligence));
            Console.WriteLine("Sagesse : " + (GetType().Name == "Mage" ? _sagesse + " + " + (Sagesse - _sagesse) + " = " + Sagesse : Sagesse));
            Console.WriteLine($"Points de vie : {Pv}");
            Console.WriteLine();
            Console.WriteLine($"Or: {Or}");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
        }

     
        #endregion
    }

}

