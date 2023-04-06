using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal static class Map
    {
        public const int GroundY = 20;
        public const int MapSizeX = 40;

        public static void Draw()
        {
            Console.SetCursorPosition(0, GroundY);

            for (int x = 0; x < MapSizeX; x++)
            {
                Console.Write("#");
            }
        }
    }
}
