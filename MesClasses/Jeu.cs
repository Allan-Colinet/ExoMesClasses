using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using MesClasses.Heros;
using MesClasses.Monstres;
using MesClasses.Monstres.Monstres;
using RPG.Loot;
using RPG;

namespace MesClasses
{
    public class Jeu
    {
        //Trouver comment faire pour acheter/vendre dans la boutique (vente moitié prix) et sa stock dans l'inventaire hero
        public Jeu()
        {
            Equipements = new List<Equipement>();
            InitialiserEquipements();
        }
        //Instanciation de la list d'équipement et création des équipements
        public static List<Equipement> Equipements { get; set; }
        Personnage joueur = new Personnage();
        public void InitialiserEquipements()
        {
            Arme epeeCourte = new Arme();
            epeeCourte.nom = "Epée courte";
            epeeCourte.prix = 15;
            epeeCourte.nbFaces = 6;
            epeeCourte.nbDes = 1;
            Equipements.Add(epeeCourte);

            Arme epeeLongue = new Arme();
            epeeLongue.nom = "Epée longue";
            epeeLongue.prix = 25;
            epeeLongue.nbDes = 1;
            epeeLongue.nbFaces = 8;
            Equipements.Add(epeeLongue);

            Arme baton = new Arme();
            baton.nom = "Bâton";
            baton.prix = 10;
            baton.nbDes = 1;
            baton.nbFaces = 4;
            Equipements.Add(baton);

            Armure armureCuir = new Armure();
            armureCuir.nom = "Armure de Cuir";
            armureCuir.Armures = 2;
            armureCuir.prix = 20;
            Equipements.Add(armureCuir);

            Armure armureArgent = new Armure();
            armureArgent.nom = "Armure d'argent";
            armureArgent.Armures = 5;
            armureArgent.prix = 50;
            Equipements.Add(armureArgent);

            Consommable potion = new Consommable();
            potion.nom = "Petite Potion de soin";
            potion.prix = 5;
            potion.nbDes = 2;
            potion.nbFaces = 4;
            Equipements.Add(potion);
        }

        #region Monstres
        //Création d'une liste de monstre pour la génération aléatoire des monstres à implémenter lors de l'appel de la méthode
        public List<Monstre>? hordeMonstre { get; set; }


        public void GenererHorde()
        {
            hordeMonstre = new List<Monstre>();
            Random rnd = new Random();

            // une boucle pour créer le nombre voulu avec instanciation du monstre et ajout à la liste selon le random effectué
            for (int i = 0; i < 10; i++)
            {
                Monstre monstre;
                int Lance = rnd.Next(1, 7);

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
                switch (listhorde)
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
        public void Shop()
        {
            
            Boutique.AfficherBoutique(Equipements);
        }
        #endregion
        //Switch pour choisir une classe si le choix correspond, instanciation du personnage choisi avec creation des stats aléatoires et affichage
        #region Classe_Perso
        public Personnage ChoixClasse()
        {
            int choix = 0;
            while (choix < 1 || choix > 3)
            {
                Console.WriteLine("Quel type de personnage voulez-vous choisir ? ");
                Console.WriteLine("1 : Guerrier");
                Console.WriteLine("2 : Mage");
                Console.WriteLine("3 : Pretre");
                choix = int.Parse(Console.ReadLine());
            }
                switch (choix)
                {
                    case 1:
                        joueur = new Guerrier();
                        break;
                    case 2:
                        joueur = new Mage();
                        break;
                    case 3:
                        joueur = new Pretre();
                        break;

                    default:
                        joueur = null; break;
                }
            
            joueur.Creation();

            //joueur.Modificateur();
            joueur.AfficherCaracteristique();

            return joueur;
        }
        #endregion
    }
}
