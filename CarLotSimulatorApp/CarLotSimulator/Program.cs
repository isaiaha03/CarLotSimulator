using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot carLot = new CarLot();
            //TODO

            //DONE: Create a seperate class file called Car
            //DONE: Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //DONE: Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //DONE: The methods should take one string parameter: the respective noise property


            //DONE: Now that the Car class is created we can instanciate 3 new cars
            //DONE: Set the properties for each of the cars
            //DONE: Call each of the methods for each car
            Car carOne = new Car()
            {
                Year = 2020,
                Make = "Ford",
                Model = "Mustang",
                EngineNoise = "Rumble",
                HonkNoise = "Honk",
                IsDriveable = true,
            };
            carOne.MakeEngineNoise();
            carOne.MakeHonkNoise();
            carLot.AddCar(carOne);
            Console.WriteLine(CarLot.numberOfCars);

            Car carTwo = new Car() { Year = 2022, Make = "Toyota", Model = "Supra", EngineNoise = "Vroom", HonkNoise = "Beep", IsDriveable = true };
            carTwo.MakeEngineNoise();
            carTwo.MakeHonkNoise();
            carLot.AddCar(carTwo);
            Console.WriteLine(CarLot.numberOfCars);

            Car carThree = new Car();
            carThree.Year = 2023;
            carThree.Make = "Chevy";
            carThree.Model = "Silverado";
            carThree.EngineNoise = "Roar";
            carThree.HonkNoise = "Horn";
            carThree.IsDriveable = true;
            carThree.MakeEngineNoise();
            carThree.MakeHonkNoise();
            carLot.AddCar(carThree);
            Console.WriteLine(CarLot.numberOfCars);

            //*************BONUS*************//

            //DONE: Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //DONE: Create a CarLot class
            //DONE: It should have at least one property: a List of cars
            //DONE: Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //DONE: At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine("Cars in the car lot:");
            foreach (Car car in carLot.Cars)
            {
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");
            }
        }
    }
}
