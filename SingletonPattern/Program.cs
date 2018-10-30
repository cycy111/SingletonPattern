using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingletonPattern.COM.Singleton;
namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("对象只初始化一次！");
            Singleton singleton1= Singleton.GetSingletonInstance();
            Singleton singleton2 = Singleton.GetSingletonInstance();

            if (singleton1 == singleton2)
            {
                Console.WriteLine("是同一个对象！");
            }
            Console.ReadKey();

        }
    }
}
