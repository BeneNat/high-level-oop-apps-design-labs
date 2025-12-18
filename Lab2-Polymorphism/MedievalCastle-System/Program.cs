namespace MedievalCastle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List < Inhabitant > inhabitants = new List<Inhabitant>() {new Civilian(), new Crossbowman(), new Pikeman()};
            List<Civilian> civilians = new List<Civilian>() { new Civilian(), new Civilian(), new Civilian() };
            List<Defender> defenders = new List<Defender>() { new Crossbowman(), new Pikeman(), new Pikeman() };
            List<Crossbowman> crossbowmans = new List<Crossbowman>()
                { new Crossbowman(), new Crossbowman(), new Crossbowman() };
            List<Pikeman> pikemens = new List<Pikeman>() { new Pikeman(), new Pikeman(), new Pikeman() };
            
            Console.WriteLine($"Crossbowmen ready to fight: ");
            foreach (var crossbowman in crossbowmans)
            {
                Console.WriteLine(crossbowman.ReadyToFight());
            }
            
            Console.WriteLine($"\nPike men ready to fight: ");
            foreach (var pikeman in pikemens)
            {
                Console.WriteLine(pikeman.ReadyToFight());
            }
            
            Console.WriteLine($"\nDefenders ready to fight: ");
            foreach (var defender in defenders)
            {
                Console.WriteLine(defender.ReadyToFight());
            }
            
            Console.WriteLine($"\nCivilians in the castle during lunch time:");
            foreach (var civilian in civilians)
            {
                Console.WriteLine($"{civilian.Eat()} units of food was served during the meal.");
            }
            
            Console.WriteLine("\nThe inhabitants of the castle: ");
            foreach (var inhabitant in inhabitants)
            {
                Console.WriteLine($"{inhabitant.ToString()} needs {inhabitant.Eat()} food units.");
            }
        }
    }
}
