using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MesClasses.Heros;
using MesClasses.Monstres;
using MesClasses.Monstres.Monstres;
using RPG.Loot;

namespace MesClasses
{
    public class Jeu
    { 
        //Instanciation de la list d'équipement et création des équipements
        public static List<Equipements> equipements ()
        {
            List<Equipements> Stuff = new List<Equipements>();
            
            Arme epeeCourte = new Arme();
            epeeCourte.nom = "Epée courte";
            epeeCourte.prix = 20;
            epeeCourte.nbFaces = 6;
            epeeCourte.nbDes = 1;
            Stuff.Add(epeeCourte);

            //Arme epeeLongue
            //Arme baton

            Armure armureCuir = new Armure();
            armureCuir.nom = "Armure de Cuir";
            armureCuir.Armures = 2;
            armureCuir.prix = 10;
            Stuff.Add( armureCuir );

            //Armure armureArgent

            Consommable potion = new Consommable();
            potion.nom = "Petite Potion de soin";
            potion.prix = 5;
            potion.nbFaces = 4;
            potion.nbDes = 2;
            Stuff.Add( potion );
            


            // je retourne la liste instanciée pour pouvoir l'utiliser par après dans le système de loot
            return Stuff;
        }
        
        
        public void GenererInventaire()
        {
            equipements = new List<Equipements>();
            //equipements.Add(Equipements.EpeeCourte());
        }
        
        #region Monstres
        //Création d'une liste de monstre pour la génération aléatoire des monstres à implémenter lors de l'appel de la méthode
        public List<Monstre> ?hordeMonstre { get; set; }
           
        
        public void GenererHorde()
        {
            hordeMonstre = new List<Monstre>();
            Random rnd = new Random();

            // une boucle pour créer le nombre voulu avec instanciation du monstre et ajout à la liste selon le random effectué
            for (int i = 0; i < 10; i++)
            {
                Monstre monstre;
                int Lance = rnd.Next(1,7);

                if (Lance == 1)
                {
                    monstre = new Orc();
                    monstre.Creation();
                    hordeMonstre.Add(monstre);
                }
                else if (Lance == 2 || Lance == 3)
                {
                    monstre = new Loup();
                    monstre.Creation();
                    hordeMonstre.Add(monstre);
                }
                else
                {
                    monstre = new Gobelin();
                    monstre.Creation();
                    hordeMonstre.Add(monstre);
                }
            }
            
        }

        public void AfficherHorde()
        {
            //Affichage de la liste avec un foreach pour parcourir tous les Monstre dans hordeMonstre cette listhorde permet d'être la condition de switch
            foreach (Monstre listhorde in hordeMonstre)
            {
                switch(listhorde)
                {
                    case Orc orc:
                        orc.AfficherCaracteristique();
                        orc.CriDeGuerre();
                        orc.CoupDeHache();
                        break;
                    case Gobelin gobelin:
                        gobelin.AfficherCaracteristique();
                        gobelin.CoupDeMasse();
                        break;
                    case Loup loup:
                        loup.AfficherCaracteristique();
                        loup.Morsure();
                        loup.Hurlement();
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("----------------");
                Console.WriteLine();
            }

        }

        #endregion
        //Switch pour choisir une classe si le choix correspond, instanciation du personnage choisi avec creation des stats aléatoires et affichage
        #region Classe_Perso
        public void ChoixClasse()
        {
            Console.WriteLine("Quel type de personnage voulez-vous choisir ? ");
            Console.WriteLine("1 : Guerrier");
            Console.WriteLine("2 : Mage");
            Console.WriteLine("3 : Pretre");
            Console.WriteLine("4 : Quitter la partie");
            int choix = int.Parse(Console.ReadLine());
            Personnages joueur;

            switch (choix)
            {
                case 1:
                    joueur = new Guerrier();
                    joueur.Creation();
                    joueur.AfficherCaracteristique();
                    break;
                case 2:
                    joueur = new Mage();
                    joueur.Creation();
                    joueur.AfficherCaracteristique();
                    break;
                case 3:
                    joueur = new Pretre();
                    joueur.Creation();
                    joueur.AfficherCaracteristique();
                    break;
                case 4: Environment.Exit(0); break;
                default: Console.WriteLine("Veuillez choisir 1,2,3 ou 4"); break;
            }
        }
        #endregion
    }
}
