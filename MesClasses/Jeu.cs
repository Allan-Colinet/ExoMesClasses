using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses
{
    public class Jeu
    {
        #region Monstres
        List<Monstres> hordeMonstre = new List<Monstres>();
        
        public void GenererHorde()
        {
            Random rnd = new Random();
            int Lance = rnd.Next(1,7);

            
            for (int i = 0; i < 10; i++)
            {

                if (Lance == 1)
                {
                    hordeMonstre.Add(new Orc());
                }
                else if (Lance == 2 || Lance == 3)
                {
                    hordeMonstre.Add(new Loup());
                }
                else
                {
                    hordeMonstre.Add(new Gobelin());
                }
            }
            
        }

        public void AfficherHorde()
        {
            foreach (Monstres listhorde in hordeMonstre)
            {
                Console.WriteLine(listhorde);
            }

        }

        #endregion

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
                    joueur.NewPerso();
                    break;
                case 2:
                    joueur = new Mage();
                    joueur.NewPerso();
                    break;
                case 3:
                    joueur = new Pretre();
                    joueur.NewPerso();
                    break;
                case 4: Environment.Exit(0); break;
                default: Console.WriteLine("Veuillez choisir 1,2,3 ou 4"); break;
            }
        }
        #endregion
    }
}
