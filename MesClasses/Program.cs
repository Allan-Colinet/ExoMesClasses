namespace MesClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instanciation d'un nouveau guerrier et la méthode qui va générer les stats
            Guerrier jeanHubert = new Guerrier();
            
            jeanHubert.NewPerso();

            // Affichage des stats 
            Console.WriteLine($"Force de pédé : {jeanHubert.Force}");
            Console.WriteLine($"Endurance de malade : {jeanHubert.Endurance}");
            Console.WriteLine($"Intelligence de fou furieux : {jeanHubert.Intelligence}");
            Console.WriteLine($"Sagesse de Shaolin : {jeanHubert.Sagesse}");
            Console.WriteLine();
            Console.WriteLine("Are You Ready ?");
            Console.WriteLine("Fight !");
        }
    }
}
