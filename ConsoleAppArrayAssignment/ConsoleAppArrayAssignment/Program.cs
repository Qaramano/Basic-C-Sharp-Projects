using System;
using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {
        int[] testScore = { 98, 99, 85, 34, 91, 90, 94 };

        for (int i = 0; i < testScore.Length; i++)
        {
            if (testScore[i] > 85)
            {
                Console.WriteLine("Passing test score: " + testScore[i]);
            }
            Console.ReadLine();
        }
        }
    }

