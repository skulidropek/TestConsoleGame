using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Score : MonoBehaviour
    {
        private readonly Random _random = new Random();

        public int Points;

        public override void EndUpdate()
        {
            Console.SetCursorPosition(Map.MapSizeX + 4, 5);
            Console.WriteLine("Количество очков " + Points);
            Points += _random.Next(0, 10);
        }
    }
}
