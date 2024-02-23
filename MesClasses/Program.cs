namespace MesClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guerrier jeanHubert = new Guerrier();
            jeanHubert.NomPerso = "BlaBla";
            jeanHubert.NewStats();

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
