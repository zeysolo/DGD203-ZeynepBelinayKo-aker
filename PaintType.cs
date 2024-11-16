using System;

namespace CarShowroom
{
    internal class PaintType
    {
        public string paintType;


        public void PaintChoose()//Asks the user color and records the color
        {
            while (true)
            {
                Console.WriteLine("Select a paint type");
                Console.WriteLine("1 - Silvery Paint");
                Console.WriteLine("2 - Metallic Paint");
                Console.WriteLine("3 - Solid Paint");
                Console.WriteLine("4 - Matte Paint");
                paintType = Console.ReadLine();

                if (paintType == "1")
                {
                    paintType = "Silvery";
                    Console.WriteLine("You have  " + paintType + " type paint.");
                    PointSystem.DeclarePoint("paint", 5);

                    break;
                }
                else if (paintType == "2")
                {
                    paintType = "Metallic";
                    Console.WriteLine("You have  " + paintType + " type paint.");
                    PointSystem.DeclarePoint("paint", 3);

                    break;
                }
                else if (paintType == "3")
                {
                    paintType = "Solid";
                    Console.WriteLine("You have  " + paintType + " type paint.");
                    PointSystem.DeclarePoint("paint", 4);

                    break;
                }
                else if (paintType == "4")
                {
                    paintType = "Matte";
                    Console.WriteLine("You have  " + paintType + " type paint.");
                    PointSystem.DeclarePoint("paint", 2);

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