using System.Xml.Linq;
using System.Collections.Generic;

class Charmander
{
    public string Name { get; set; }
    public string Strenght { get; set; }
    public string Weakness { get; set; }

    public Charmander(string name,string strenght, string weakness) 
    {
        Name = name;
        Strenght = strenght;
        Weakness = weakness;

    }

    public string GetName()
    {
        return Name;
    }

    public void SetName(string NewName)
    {
        Name = NewName;
    }

    public string GetStrenght()
    {
        return Strenght;
    }

    public void SetStrenght(string NewStrenght)
    {
        Strenght = NewStrenght;
    }
    public string GetWeakness()
    {
        return Weakness;
    }

    public void SetWeakness(string NewWeakness)
    {
        Weakness = NewWeakness;
    }

    public void Battlecry() 
    {
        Console.WriteLine($"Your pokemon calls out his name: {Name}!");
    }    
}

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("What would you like to call the Charmander? : ");
            string Charmander_Name = Console.ReadLine();
            Charmander charmander1 = new Charmander(Charmander_Name, "Fire", "Water");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(charmander1.GetName());
            }
        }
    }
}