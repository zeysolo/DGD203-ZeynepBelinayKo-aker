using System;

namespace CarShowroom
{
    internal class Car
    {
        static void Main(string[] args)
        {
            CarType carType = new CarType();
            CarColor carColor = new CarColor();
            RimType rimType = new RimType();
            PaintType paintType = new PaintType();
            Sticker sticker = new Sticker();
            bool isGameOver = false;
            Console.WriteLine("Customize your car and present it at the showroom");
            Console.ForegroundColor = ConsoleColor.Green;
            while (!isGameOver)
            {
                while (true)
                {
                    Console.WriteLine("CHOOSE AN ACTION");
                    Console.WriteLine("1 - Choose Car Type");
                    Console.WriteLine("2 - Choose Car Color");
                    Console.WriteLine("3 - Choose Paint Type");
                    Console.WriteLine("4 - Choose Rim Type");
                    Console.WriteLine("5 - Choose Sticker");
                    Console.WriteLine("6 - Information about your car");
                    Console.WriteLine("7 - Present Your Car");
                    string playerChoice = Console.ReadLine();

                    if (playerChoice == "1")
                    {
                        carType.TypeChoose();

                        break;
                    }
                    else if (playerChoice == "2")
                    {
                        carColor.ColorChoose();

                        break;
                    }
                    else if (playerChoice == "3")
                    {
                        paintType.PaintChoose();
                        break;
                    }
                    else if (playerChoice == "4")
                    {
                        rimType.RimChoose();

                        break;
                    }
                    else if (playerChoice == "5")
                    {
                        sticker.StickerChoose();
                        break;
                    }
                    else if (playerChoice == "6")
                    {

                        Console.WriteLine($"Your car type is {carType.carType}");
                        Console.WriteLine($"You have {carColor.carColor} colored car and the paint is {paintType.paintType}");
                        Console.WriteLine($"You have {rimType.rimType} rims and the sticker is {sticker.stickerType}");
                        break;
                    }
                    else if (playerChoice == "7")
                    {
                        //It should have all types before giving points
                        if (PointSystem.ShowRoomCheck())
                        {
                            Console.WriteLine("YOUR POINT IS " + PointSystem.TotalPoints() + " POINTS");
                            isGameOver = true;
                            break;
                        }
                        else if (!PointSystem.ShowRoomCheck())
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;

                            Console.WriteLine("YOU DID NOT CHOOSE EVERYTHING FOR YOUR CAR");
                            Console.ForegroundColor = ConsoleColor.Green;

                            break;
                        }
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Beep();
                        Console.WriteLine("You didn't give an appropriate answer. Please try again.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
            Console.WriteLine("Press enter to exit the game");
            Console.ReadLine();
        }

    }
}