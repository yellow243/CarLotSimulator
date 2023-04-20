using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            //#1
            var lot = new CarLot();

            var zachsCar = new Car();
            zachsCar.Make = "Honda";
            zachsCar.Model = "HR-V";
            zachsCar.Year = 2021;
            zachsCar.EngineNoise = "merrrrrr";
            zachsCar.HonkNoise = "meep meep";
            zachsCar.IsDriveable = true;

            lot.Cars.Add(zachsCar);

            //#2
            var dadsCar = new Car()
            {
                Year = 2019,
                Make = "BMW",
                Model = "M5 Sports Competition",
                EngineNoise = "VRRRRRrrrrrrr",
                HonkNoise = "MERRRRRR",
                IsDriveable = true
            };
            lot.Cars.Add(dadsCar);
            //#3
            var bffsCar = new Car(2016, "Hyundai", "Elantra", "Mrrr pop mrrrr eeee mrrrrr", "HOOOOOONK", true);

            lot.Cars.Add(bffsCar);



            //Call methods
            zachsCar.MakeEngineNoise(zachsCar.EngineNoise);
            dadsCar.MakeEngineNoise(dadsCar.EngineNoise);
            bffsCar.MakeEngineNoise(bffsCar.EngineNoise);


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

           foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }


        }
    }
}
