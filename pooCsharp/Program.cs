
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("entre le nom d'un animal");
        string animalName = Console.ReadLine();
        Animal animal = new Animal(animalName);
        animal.Move();
        animal.Sleep();
    }
}