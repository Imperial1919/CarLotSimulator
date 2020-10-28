using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            var FordTBird = new Car("Ford", "Thunderbird", 1955, "HONK", true, true);





            Console.WriteLine($"This is a {FordTBird.Year} {FordTBird.Make} {FordTBird.Model} and I shall now demostrate some features, noteably the horn first.");

            FordTBird.MakeHonkNoise();

            Console.WriteLine($"NOW!, Let's see if she runs!");
            FordTBird.MakeEngineNoise();



            var CadillacSeville = new Car("Cadillac", "Seville", 1959, "HONK", true, true);





            Console.WriteLine($"This is a {CadillacSeville.Year} {CadillacSeville.Make} {CadillacSeville.Model}. A Big girl indeed, 20 feet long if You can imagine it! As per routine, I shall now demostrate some features, noteably the horn first.");
            CadillacSeville.MakeHonkNoise();
            Console.WriteLine($"NOW!, Let's see if she runs!");
            CadillacSeville.MakeEngineNoise();


            var Packard = new Car("Packard", "Deluxe Phaeton", 1931, "HONK", true, true);





            Console.WriteLine($"This is a {Packard.Year} {Packard.Make} {Packard.Model}. A Big girl indeed, 20 feet long if You can imagine it! As per routine, I shall now demostrate some features, noteably the horn first.");
            Packard.MakeHonkNoise();
            Console.WriteLine($"NOW!, Let's see if she runs!");
            Packard.MakeEngineNoise();


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
