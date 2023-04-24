using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car() 
        {
            CarLot.numberOfCars++;
        }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDrivable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDrivable;
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }


        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine("What sound does the car make while it drives?");
            Console.WriteLine();
            Console.WriteLine(engineNoise);
            Console.WriteLine();
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine("What does the car's horn sound like?");
            Console.WriteLine();
            Console.WriteLine(honkNoise);
            Console.WriteLine();
        }















    }
}
