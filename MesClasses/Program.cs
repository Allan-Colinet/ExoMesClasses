namespace MesClasses
{
    public class Program : Personnages
    {
        static void Main(string[] args)
        {
            // instanciation d'un nouveau guerrier et la méthode qui va générer les stats
            Guerrier G = new Guerrier();
            
            G.NewPerso();

            // Affichage des stats 
            G.AfficherStat();
            
        }
    }
}
