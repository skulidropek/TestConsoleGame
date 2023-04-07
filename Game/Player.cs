using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Player : MonoBehaviour
    {
        private Entity _entity;
        private PlayerAnimation _playerAnimation;
        private Score _score;
        public bool IsGround => Map.GroundY == _entity.Position.Y + _entity.Sprite.GetLength(0);

        public Player()
        {
            _entity = AddComponent<Entity>();
            _playerAnimation = AddComponent<PlayerAnimation>();
            _score = AddComponent<Score>();

            AddComponent<Collider>().CollisionEnter += OnCollisionEnter;

            _entity.Sprite = PlayerSprite.Sprite;

            _entity.Position = new Point(4, Map.GroundY - _entity.Sprite.GetLength(0));

            Task.Run(Input);
        }

        private void OnCollisionEnter(Collider collider)
        {
            Console.Clear();
            Console.WriteLine("Вы проиграли. Опыт который вы получили " + _score.Points);
            Console.ReadLine();

            Process.GetCurrentProcess().Kill();
        }

        public override void StartUpdate()
        {
            if (_playerAnimation.Animation != PlayerAnimation.EAnimation.Default) return;

            _entity.Draw();
        }

        private async void Input()
        {
            while (true)
            {
                ConsoleKey consoleKey = Console.ReadKey(true).Key;

                if (_playerAnimation.Animation == PlayerAnimation.EAnimation.Default)
                {
                    switch (consoleKey)
                    {
                        case ConsoleKey.Spacebar:
                            Jump();
                            break;
                    }
                }
            }
        }

        public override void EndUpdate()
        {
            if (_playerAnimation.Animation == PlayerAnimation.EAnimation.Default) return;
            _entity.Clear();
        }

        public void Jump()
        {
            if (IsGround)
            {
                _playerAnimation.JumpAnimation();
            }
        }
    }
}
