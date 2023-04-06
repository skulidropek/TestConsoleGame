using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal abstract class Component : Object
    {
        private List<Component> _components = new List<Component>();
        public List<Component> Components => Parrent == null ? _components : ((Component)Parrent).Components;
        public Object Parrent { get; private set; }

        public T GetComponent<T>() where T : Component
        {
            Component component = Components.FirstOrDefault(c => c is T);

            if (component == null)
                return null;

            return (T)component;
        }

        public T AddComponent<T>() where T : Component, new()
        {
            T t = new T();
            t.Parrent = this;
            Components.Add(t);

            (t as MonoBehaviour).Start();
            return t;
        }

        public override void Destroy()
        {
            if (Components.Contains(this))
                Components.Remove(this);

            base.Destroy();
        }
    }
}
