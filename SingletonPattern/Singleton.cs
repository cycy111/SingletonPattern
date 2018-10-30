using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Contexts;
namespace SingletonPattern
{
    [Synchronization]
    public class Singleton: ContextBoundObject
    {
        public static Singleton singleton=null;
        private Singleton()
        {
            Console.WriteLine("实例化单例对象！");
        }
        public  static Singleton GetSingletonInstance()
        {
            if (singleton == null)
            {
                singleton = new Singleton();
            }
            return singleton;
        }

    }
}
