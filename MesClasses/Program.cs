namespace MesClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Initialisation de la partie et des méthodes nécessaires au fonctionnement du jeu avec des affichages pour s'assurer que tout ce qui est déjà implémenté fonctionne
            Jeu partie = new Jeu();
            partie.ChoixClasse();
            //partie.genererstuff();
            partie.GenererHorde();
            partie.AfficherHorde();
        }
    }
}
