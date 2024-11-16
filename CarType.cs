using System;

namespace CarShowroom
{
    internal class CarType
    {
        public string carType;


        public void TypeChoose()//Asks the user color and records the color

        {
            while (true)
            {
                Console.WriteLine("Select a car type");
                Console.WriteLine("1 - Cabriolet Car");
                Console.WriteLine("2 - Sports Car");
                Console.WriteLine("3 - Muscle Car");
                Console.WriteLine("4 - Vintage Car");
                carType = Console.ReadLine();

                if (carType == "1")
                {
                    carType = "Cabriolet";
                    Console.WriteLine("You have  " + carType + " type car.");
                    PointSystem.DeclarePoint("cartype", 5);

                    break;
                }
                else if (carType == "2")
                {
                    carType = "Sports";
                    Console.WriteLine("You have  " + carType + " type car.");
                    PointSystem.DeclarePoint("cartype", 4);

                    break;
                }
                else if (carType == "3")
                {
                    carType = "Muscle";
                    Console.WriteLine("You have  " + carType + " type car.");
                    PointSystem.DeclarePoint("cartype", 3);

                    break;
                }
                else if (carType == "4")
                {
                    carType = "Vintage";
                    Console.WriteLine("You have  " + carType + " type car.");
                    PointSystem.DeclarePoint("cartype", 5);

                    break;
                }
                else
                {
                    Console.WriteLine("Try again Please");

                }
            }
        }
    }
}