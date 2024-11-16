using System;

namespace CarShowroom
{
    internal class CarColor
    {

        public string carColor;


        public void ColorChoose()//Asks the user color and records the color

        {
            while (true)
            {
                Console.WriteLine("Select a car color");
                Console.WriteLine("1 - Green");
                Console.WriteLine("2 - Brownish Green");
                Console.WriteLine("3 - Emerald Green");
                Console.WriteLine("4 - Forest Green");
                Console.WriteLine("5 - Another Green");
                Console.WriteLine("6 - Mevlana Green");
                carColor = Console.ReadLine();

                if (carColor == "1")
                {
                    carColor = "Green";
                    Console.WriteLine("Your cars color is  " + carColor);
                    PointSystem.DeclarePoint("color", 4);

                    break;
                }
                else if (carColor == "2")
                {
                    carColor = "Brownish Green";
                    Console.WriteLine("Your cars color is  " + carColor);
                    PointSystem.DeclarePoint("color", 5);

                    break;
                }
                else if (carColor == "3")
                {
                    carColor = "Emerald Green";
                    Console.WriteLine("Your cars color is  " + carColor);
                    PointSystem.DeclarePoint("color", 3);

                    break;
                }
                else if (carColor == "4")
                {
                    carColor = "Forest Green";
                    Console.WriteLine("Your cars color is  " + carColor);
                    PointSystem.DeclarePoint("color", 4);

                    break;
                }
                else if (carColor == "5")
                {
                    carColor = "Another Green";
                    Console.WriteLine("Your cars color is  " + carColor);
                    PointSystem.DeclarePoint("color", 3);

                    break;
                }
                else if (carColor == "6")
                {
                    carColor = "Mevlana Green";
                    Console.WriteLine("Your cars color is  " + carColor);
                    PointSystem.DeclarePoint("color", 5);

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