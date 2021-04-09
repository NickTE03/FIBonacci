using System;

namespace FIBonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            for(n3=2; n3 < 3000; ++n3)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3);
                n1 = n2;
                n2 = n3;
            }
            

        }
    }
}
