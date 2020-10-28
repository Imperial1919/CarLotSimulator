using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{

    public class Car
    {


        public Car(string make, string model, int year, string honknoise, bool isdrivable = false, bool enginenoise = false)
        {
            Make = make;
            Model = model;
            Year = year;
            IsDrivable = isdrivable;
            Honknoise = honknoise;
            EngineNoise = enginenoise;
        }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public string Honknoise { get; set; }

        public bool EngineNoise { get; set; }

        public bool IsDrivable { get; set; }


        public void MakeHonkNoise()
        {

            Console.WriteLine(Honknoise);
        }


        public void MakeEngineNoise()
        {
            Console.WriteLine("VRROOOOOOMMMM");
        }

        public void IsitDrivable()
        {
            Console.WriteLine("It's also totally able to run too!");


        }




    }



}


