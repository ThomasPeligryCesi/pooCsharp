
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("entre le nom d'un griffon");
        string griffinName = Console.ReadLine();
        Console.WriteLine("entre le nom d'un dragon");
        string dragonName = Console.ReadLine();
        Griffin griffin = new Griffin(griffinName);
        Dragon dragon = new Dragon(dragonName);
        Vehicle voiture = new Vehicle();

        voiture.Move2();
        dragon.Move();
        dragon.Sleep();
        griffin.Move();
        griffin.Sleep();
    }
}