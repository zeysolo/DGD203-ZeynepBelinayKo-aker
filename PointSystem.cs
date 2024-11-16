using System;

namespace CarShowroom
{
    public static class PointSystem
    {

        public static int PaintPoint = 0;
        public static int ColorPoint = 0;
        public static int CarTypePoint = 0;
        public static int RimTypePoint = 0;
        public static int StickerPoint = 0;
        public static void DeclarePoint(string name, int point)
        {
            if (name == "paint")
            {
                PaintPoint = point;
            }
            else if (name == "color")
            {
                ColorPoint = point;
            }
            else if (name == "cartype")
            {
                CarTypePoint = point;
            }
            else if (name == "rim")
            {
                RimTypePoint = point;
            }
            else if (name == "sticker")
            {
                StickerPoint = point;
            }
        }
        public static int TotalPoints()
        {
            return PaintPoint + ColorPoint + CarTypePoint + RimTypePoint + StickerPoint;
        }
        public static bool ShowRoomCheck()
        {
            if (CarTypePoint != 0 && PaintPoint != 0 && ColorPoint != 0 && RimTypePoint != 0 && StickerPoint != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}