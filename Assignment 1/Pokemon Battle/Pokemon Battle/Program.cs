using System.Xml.Linq;
using System.Collections.Generic;
namespace Pokemon_Battle_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("What would you like to call the Charmander? : ");
                string Charmander_Name = Console.ReadLine();
                Charmander charmander1 = new Charmander(Charmander_Name, "Fire", "Water");
                for (int i = 0; i < 1; i++)
                {
                    Console.WriteLine(charmander1.GetName());
                }
            }
        }
    }
}