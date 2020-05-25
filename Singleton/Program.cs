using System;

namespace Singleton
{
    interface Interface1
    {
        void TestInterface();
    }
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static void TestStaticAndSingleton(SingletonClass singleton)
        {

        }
    }

    public static class StaticClass // : Interface1  -> error
    {
    }

    public sealed class SingletonClass : Interface1
    {
        public void TestInterface()
        {
            throw new NotImplementedException();
        }

        private SingletonClass()
        {

        }

        private static volatile SingletonClass instance;
        private static object syncRoot = new Object();
        private static SingletonClass Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonClass();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
