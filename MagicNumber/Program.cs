﻿internal class magic
{
    private static void Main()
    {
        int magic = int.Parse(Console.ReadLine());
        for (int d1 = 0; d1 <= 9; d1++)
        {
            for (int d2 = 0; d2 <= 9; d1++)
            {
                for (int d3 = 0; d3 <= 9; d1++)
                {
                    for (int d4 = 0; d4 <= 9; d1++)
                    {
                        for (int d5 = 0; d5 <= 9; d1++)
                        {
                            for (int d6 = 0; d6 <= 9; d1++)
                            {
                                if ((d1 * d2 * d3 * d4 * d5 * d6) == magic)
                                {
                                    Console.WriteLine("{0}{1}{2}{3}{4}{5}", d1, d2, d3, d4, d5, d6);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}