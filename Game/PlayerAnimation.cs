using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class PlayerAnimation : MonoBehaviour
    {
        private Entity _entity;

        public override void Start()
        {
            _entity = GetComponent<Entity>();
        }

        public EAnimation Animation = EAnimation.Default;

        public void JumpAnimation()
        {
            Animation = EAnimation.Up;
        }

        public override void EndUpdate()
        {
            if (Animation == EAnimation.Default) return;

            if(Animation == EAnimation.Up)
            {
                if(_entity.Position.Y >= Map.GroundY - 14)
                {
                    _entity.Clear();
                    _entity.Position.Y--;
                    _entity.Draw();
                    return;
                }

                Animation = EAnimation.Down;
            }

            if (_entity.Position.Y <= Map.GroundY - _entity.Sprite.GetLength(0) - 1)
            {
                _entity.Clear();
                _entity.Position.Y++;
                _entity.Draw();
                return;
            }
            
            Animation = EAnimation.Default;
        }

        public enum EAnimation
        {
            Default = 0,
            Up = 1,
            Down = 2,
        }
    }
}
