using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Wall : MonoBehaviour
    {
        private Entity _entity;

        public Point Point => _entity.Position;

        public Wall()
        {
            _entity = AddComponent<Entity>();
            _entity.Sprite = new char[,]
            {
                { '|', },
                { '|', },
            };

            AddComponent<Collider>();

            _entity.Position = new Point(Map.MapSizeX, Map.GroundY - _entity.Sprite.GetLength(0));
        }

        public override void StartUpdate()
        {
            _entity.Draw();
        }

        public override void EndUpdate()
        {
            _entity.Clear();
            //for (int i = 0; i < walls.Count; i++)
            //{
            //    if (walls[i].Position.X == 0)
            //    {
            //        if (walls.Count > 1)
            //        {
            //            walls.Remove(walls[i]);
            //            continue;
            //        }
            //        walls[i].Position.X = Map.MapSizeX;
            //    }

            //}

            if (_entity.Position.X == 0)
            {
                //if (_entity.Count > 1)
                //{
                //    walls.Remove(walls[i]);
                //    continue;
                //}
                _entity.Position.X = Map.MapSizeX;
            }

            if (_entity.Position.X > 0)
            {
                _entity.Position.X--;
            }

            //if (player.IsCollider(walls[i]))
            //{
            //    Console.Clear();
            //    Console.WriteLine($"Вы проиграли. Вы собрали {points} очков");
            //    Console.ReadKey();
            //    return;
            //}

            //if (walls.Count < 2 && Map.MapSizeX - walls[i].Position.X > 10 && random.Next(0, 30) == 2)
            //{
            //    walls.Add(new Wall());
            //}
            //}
        }
    }
}
