using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Collider : MonoBehaviour
    {
        private Entity _entity;

        public override void Start()
        {
            _entity = GetComponent<Entity>();
        }

        public Action<Collider> CollisionEnter = delegate { };

        public override void EndUpdate()
        {
            Collider[] colliders = FindObjectsByType<Collider>();

            foreach (Collider collider in colliders)
            {
                if (collider == this) continue;

                if (_entity.IsCollider(collider._entity))
                {
                    OnCollisionEnter(collider);
                    collider.OnCollisionEnter(this);
                }
            }
        }

        public void OnCollisionEnter(Collider collider)
        {
            CollisionEnter.Invoke(collider);
        }
    }
}
