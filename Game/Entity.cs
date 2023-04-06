using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Entity : MonoBehaviour
    {
        public char[,] Sprite;

        public Point Position;

        public virtual void Draw()
        {
            for (int y = 0; y < Sprite.GetLength(0); y++)
            {
                for (int x = 0; x < Sprite.GetLength(1); x++)
                {
                    Console.SetCursorPosition(x + Position.X, y + Position.Y);
                    Console.Write(Sprite[y, x]);
                }
            }
        }

        public virtual void Clear()
        {
            for (int y = 0; y < Sprite.GetLength(0); y++)
            {
                for (int x = 0; x < Sprite.GetLength(1); x++)
                {
                    Console.SetCursorPosition(x + Position.X, y + Position.Y);
                    Console.Write(" ");
                }
            }
        }

        public bool IsCollider(Entity entity)
        {
            if (Position == entity.Position) return true;

            return 
                Position.X <= entity.Position.X && entity.Position.X <= Position.X + Sprite.GetLength(1) &&
                Position.Y <= entity.Position.Y && entity.Position.Y <= Position.Y + Sprite.GetLength(0);
        }
    }
}
