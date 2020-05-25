using System;

namespace RestrictedClass
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                new Program();
            }
        }

        private static int instanceCount { get; set; }

        public Program()
        {
            if (instanceCount == 3)
            {
                throw new InvalidOperationException("oNLY 3 INSTANCES ALLOWED");
            }
            instanceCount ++;
        }
    }
}
