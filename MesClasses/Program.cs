namespace MesClasses
{
    public class Program
    {
        static void Main(string[] args)
        {



            Jeu partie = new Jeu();
            partie.ChoixClasse();
            partie.GenererHorde();
            partie.AfficherHorde();
        }
    }
}
