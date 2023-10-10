using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            var peacock = new Bird();
            peacock.WingColor = "purple";
            peacock.CanFly = false;
            peacock.WillMigrate = true;
            peacock.BeakLength = 4;

            var snake = new Reptile();
            
            snake.IsColdBlooded = true;
            snake.IsScaly = true;
            snake.Habitat = "Jungle";
            snake.CanRegrowTail = false;

            var myAnimals = new Animal[] { peacock, snake };

            foreach(var animal in myAnimals)
            {
                Console.WriteLine($"Alive:{animal.IsAlive}");
                Console.WriteLine($"Age:{animal.Age} years old");
                Console.WriteLine($"It has:{animal.LegCount} legs");
                Console.WriteLine($"It lives on {animal.LandSeaAir}");
                Console.WriteLine($"");


            }



        }
    }
}
