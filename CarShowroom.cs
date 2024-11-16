using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroom
{
    internal class Sticker
    {
        public string stickerType;

        public void StickerChoose()//Asks the user color and records the color
        {
            while (true)
            {
                Console.WriteLine("Select a sticker");
                Console.WriteLine("1 - Fox Sticker");
                Console.WriteLine("2 - Gorillaz Sticker");
                Console.WriteLine("3 - Wild Boar Sticker");
                Console.WriteLine("4 - Frog Sticker");
                stickerType = Console.ReadLine();

                if (stickerType == "1")
                {
                    stickerType = "Fox";
                    Console.WriteLine("You have  " + stickerType + " type sticker.");
                    Console.WriteLine("  ,-='\"-._               /\\/\\\r\n   `-.}       `=.,.-==-..,  @ @.,\r\n      `-.__   _,-.   )       _,.-'\r\n           `\"     G..m-\"^m`m'       ");
                    PointSystem.DeclarePoint("sticker", 5);
                    break;
                }
                else if (stickerType == "2")
                {
                    stickerType = "Gorillaz";
                    Console.WriteLine("You have  " + stickerType + " type sticker.");
                    Console.WriteLine("              .\"\".\r\n              .-./ _=_ \\.-.\r\n             {  (,(oYo),) }}\r\n             {{ |   \"   |} }\r\n             { { \\(---)/  }}\r\n             {{  }'-=-'{ } }\r\n             { { }._:_.{  }}\r\n             {{  } -:- { } }\r\n       jgs   {_{ }===`{  _}\r\n            ((((\\)     (/))))");
                    PointSystem.DeclarePoint("sticker", 4);

                    break;
                }
                else if (stickerType == "3")
                {
                    stickerType = "Wild Boar";
                    Console.WriteLine("You have  " + stickerType + " type sticker.");
                    Console.WriteLine("              ,-\"\"\"\"-..\r\n         |`,-'. `  ` ``  `--'\"\"\".\r\n         ;  ,'  | ``  ` `  ` ```  `.\r\n       ,-'   ..-' ` ` `` `  `` `  ` |==.\r\n     ,'    ^    `  `    `` `  ` `.  ;   \\\r\n    `}_,-^-   _ .  ` \\ `  ` __ `   ;    #\r\n       `\"---\"' -. ` \\---\"\"..  ;\r\n                  \\\\ ;       ; `. ,\r\n                   ||;      / / | |\r\n      jrei        //;`    ,;' ,_;\"");
                    PointSystem.DeclarePoint("sticker", 3);

                    break;
                }
                else if (stickerType == "4")
                {
                    stickerType = "Frog";
                    Console.WriteLine("You have  " + stickerType + " type sticker.");
                    Console.WriteLine("         o  o   o  o\r\n         |\\/ \\^/ \\/|\r\n         |,-------.|\r\n       ,-.(|)   (|),-.\r\n       \\*. ' '_.* _/\r\n        /-.--' .-'\\\r\n   ,--./    `---'    \\,--.\r\n   \\   |(  )     (  )|   /\r\nhjw \\  | ||       || |  /\r\n`97  \\ | /|\\     /|\\ | /\r\n     /  \\-._     _,-/  \\\r\n    //| \\\\  `---'  // |\\\\\r\n   /,-.,-.\\       /,-.,-.\\\r\n  o   o   o      o   o    o");
                    PointSystem.DeclarePoint("sticker", 5);

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