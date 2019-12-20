using System;

namespace BonjourBasics
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Car car = new MiniCar();
            // MiniCar miniCar = new RaceCar();
            //RaceCar raceCar = new RaceCar();

            //Console.WriteLine(car.Speed());
            //Console.WriteLine(miniCar.Speed());
            //Console.WriteLine(raceCar.Speed());

            Console.ReadLine();

        }
    }

    internal class Car
    {
        public Car()
        {
            Console.WriteLine("Car");
        }

        public int Speed()
        {
            return 0;
        }
    }

    internal class MiniCar : Car
    {

        public MiniCar()
        {
            Console.WriteLine("MiniCar");
        }

        public new int Speed()
        {
            return 60;
        }
    }

    internal class RaceCar : MiniCar
    {
        public RaceCar()
        {
            Console.WriteLine("RaceCar");
        }

        public new int Speed()
        {
            return 150;
        }

        public string Power()
        {
            return "750CC";
        }
    }

}
