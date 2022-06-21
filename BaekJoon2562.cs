using System;

namespace program
{
    class Program
    {
        private static int[] arrn;
        static void Main(string[] args)
        {
            arrn = new int[9];
            int maxi = arrn[0];
            int count = 0;

            for (int i = 0; i < 9; i++)
            {
                arrn[i] = int.Parse(Console.ReadLine());

                if (arrn[i] > maxi)
                {
                    maxi = arrn[i];
                    count = i + 1;
                }

            }

            Console.WriteLine("{0}", maxi);
            Console.WriteLine("{0}", count);


        }
    }
}

