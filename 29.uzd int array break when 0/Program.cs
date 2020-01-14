using System;

namespace _29.uzd_int_array_break_when_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 1, 1, 0, 1, 1, 1, 1 };

            int n = 0;

            do
            {
                if (numbers[n] == 0)
                {
                    Console.WriteLine($"{numbers[n]} is find in position {n}");
                    break;
                }
                n++;
                continue;
            }
            while (true);
        }
    }
}
// Izveidot int masīvu ar vērtībām 1,1,1,0,1,1,1, 1. Programmai ir jāpārtrauc darbs, kad atrodam 0. Izmantojam break;