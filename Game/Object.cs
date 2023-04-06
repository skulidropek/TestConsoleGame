using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal abstract class Object : IDisposable
    {
        public static List<Object> Objects = new List<Object>();

        public Object()
        {
            Objects.Add(this);
        }

        public static T FindObjectByType<T>() where T : Component
        {
            Object obj = Objects.FirstOrDefault(o => o is T);

            if (obj == null) 
                return null;

            return obj as T;
        }

        public static T[] FindObjectsByType<T>() where T : Component
        {
            List<T> list = new List<T>();
            for (int i = 0; i < Object.Objects.Count; i++)
            {
                Object obj = Object.Objects[i];
                if (obj is T)
                {
                    list.Add(obj as T);
                }
            }

            return list.ToArray();
        }

        public virtual void Destroy()
        {
            Objects.Remove(this);
            Dispose();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
