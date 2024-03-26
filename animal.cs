using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Animal
{
    public Animal()
    {
        this.Name = "Random Animal";
    }
    public Animal(string name)
    {
        this.Name = name;
    }
    private string Name;
    public void move()
    {
        console.WriteLine(Name + "se dandine et se déplace!");
    }
    public void Sleep()
    {
        console.WriteLine(Name + "s'est endormi et ronfle fort!");
    }
}

