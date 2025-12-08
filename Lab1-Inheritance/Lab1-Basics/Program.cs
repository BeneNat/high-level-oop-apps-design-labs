namespace zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Bird birdone = new Bird();
            birdone.method();
            Console.WriteLine($"Bird name: {birdone.name}");
            Flamingo sims = new Flamingo();
            sims.method_flamingo();
            Console.WriteLine($"Flamingo name: {sims.name}");
            sims.LayEggs(2);
            sims.Incubation(3, 12);
            Animal dog = new Animal("Dog", 6);
            Bird falcon = new Bird("Falcon", 6, 120);
            falcon.method();
        }
    }
}
