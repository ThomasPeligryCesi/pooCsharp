using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public abstract class Animal
{
    public string Name { get; protected set; }
    public abstract void Move();
    public abstract void Sleep();
}
