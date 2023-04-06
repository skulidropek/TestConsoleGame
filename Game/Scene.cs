using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Scene : MonoBehaviour
    {
        private Random _random = new Random();

        public override void Start()
        {
            Map.Draw();

            new Player();
            new Wall();
        }

        public override void StartUpdate() // Можно было вынести логику в отдельный класс WallManager
        {
            Wall[] walls = FindObjectsByType<Wall>();

            for (int i = 0; i < walls.Length; i++)
            {
                if (walls[i].Point.X == 0)
                {
                    if (walls.Length > 1)
                    {
                        walls[i].Destroy();
                        continue;
                    }
                }

                if (walls.Length < 2 && Map.MapSizeX - walls[i].Point.X > 13 && _random.Next(0, 10) == 2)
                {
                    new Wall();
                }
            }
        }
    }
}