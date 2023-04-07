using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Security.Policy;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Scene().Start();

            Console.SetWindowSize(70, 20);

            Console.CursorVisible = false;

            while (true)
            { 
                MonoBehaviour[] monoBehaviours1 = Object.FindObjectsByType<MonoBehaviour>();

                foreach (MonoBehaviour monoBehaviour in monoBehaviours1)
                {
                    monoBehaviour.StartUpdate();
                }

                Thread.Sleep(100);

                foreach (MonoBehaviour monoBehaviour in monoBehaviours1)
                {
                    monoBehaviour.EndUpdate();
                }
            }
        }
    }
}
