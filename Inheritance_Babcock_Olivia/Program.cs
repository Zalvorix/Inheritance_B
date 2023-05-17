using System;

namespace Inheritance_Babcock_Olivia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates platformer object
            Platformer princePersia = new Platformer("T", "Prince of Persia: The Sands of Time");
            Console.WriteLine(princePersia.Describe());
            // Calls game genre object
            princePersia.PlayGame();

            // Creates platformer object
            Platformer sa2 = new Platformer("E", "Sonic Adventure 2");
            Console.WriteLine(sa2.Describe());
            // Calls game genre object
            sa2.PlayGame();
        }
    }
}
