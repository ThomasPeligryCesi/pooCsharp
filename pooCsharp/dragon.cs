public class Dragon : Animal, IPilotage
{
    Dragon()
    {
        this.Name = "Random dragon";
    }
    public Dragon(string name)
    {
        this.Name = name;
    }
    public override void Move()
    {
        Console.WriteLine("*flap flap, bruits du gros " + this.Name + " le dragon qui bouge*");
    }
    public void Move2()
    {
        Console.WriteLine("*flap flap, bruits du gros " + this.Name + " le dragon qui bouge mais en pilotant*");
    }
    public override void Sleep()
    {
        Console.WriteLine("*"+ this.Name + " le dragon fait dodo pepouze*");
    }
}
