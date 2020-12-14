using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //单例模式
    class Singleton
    {
        public static Singleton Instance;
        private static object locker = new object();
        public static Singleton GetInstance()
        {
            if (Instance==null)
            {
                lock (locker)
                {
                    if (Instance==null)
                    {
                        Instance = new Singleton();
                    }
                 
                }
            }
            return Instance;
        }
        public static void Main(string[] args)
        {
            Singleton s1 =Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();
            Console.Write("s1是否等于s2:{0}", s1 == s2);
            Console.ReadLine();
        }
    }

    
}
