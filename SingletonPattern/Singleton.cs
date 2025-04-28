using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Singleton
    {
        private static int Counter = 0;
        //private static Singleton Instance = null;
        //private static readonly object Instancelock = new object();
        //public static Singleton GetInstance()
        //{
        //    // Thread-safe singleton implementation with double checked locking
        //    if (Instance == null)
        //    {
        //        lock (Instancelock)
        //        {
        //            if (Instance == null)
        //            {
        //                Instance = new Singleton();
        //            }
        //        }
        //    }
        //    return Instance;
        //}

        // Lazy initialization
        private static readonly Lazy<Singleton> lazyInstance = new Lazy<Singleton>(() => new Singleton());
        public static Singleton GetInstance
        {
            get
            {
                return lazyInstance.Value;
            }
        }

        private Singleton()
        {
            Counter++;
            Console.WriteLine("Counter Value " + Counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}