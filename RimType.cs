using System;

namespace CarShowroom
{
    internal class RimType
    {
        public string rimType;


        public void RimChoose()//Asks the user color and records the color
        {
            while (true)
            {
                Console.WriteLine("Select a rim type");
                Console.WriteLine("1 - Flaming Rim");
                Console.WriteLine("2 - Green Rim");
                Console.WriteLine("3 - Skull Patterned Rim");
                Console.WriteLine("4 - Obi Wan Kenobi Headed Rim");
                rimType = Console.ReadLine();

                if (rimType == "1")
                {
                    rimType = "Flaming";
                    Console.WriteLine("You have  " + rimType + " type rim.");
                    PointSystem.DeclarePoint("rim", 5);

                    break;
                }
                else if (rimType == "2")
                {
                    rimType = "Green";
                    Console.WriteLine("You have  " + rimType + " type rim.");
                    PointSystem.DeclarePoint("rim", 3);

                    break;
                }
                else if (rimType == "3")
                {
                    rimType = "Skull Patterned";
                    Console.WriteLine("You have  " + rimType + " type rim.");
                    PointSystem.DeclarePoint("rim", 3);

                    break;
                }
                else if (rimType == "4")
                {
                    rimType = "Obi Wan Kenobi";
                    Console.WriteLine("You have  " + rimType + " type rim.");
                    PointSystem.DeclarePoint("rim", 6);

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