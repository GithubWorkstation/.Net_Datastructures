﻿using System;

namespace Linearsearchdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            RunApplication();
        }

        public static void RunApplication()
        {
            int[] marks = new int[10] { 56, 90, 76, 88, 82, 67, 98, 83, 67, 79 };

            Console.WriteLine("Enter marks to search and press Enter:");
            string input = Console.ReadLine();
            int search = Int32.Parse(input);

            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] == search)
                {
                    Console.WriteLine(marks[i] + " was found at location " + i);
                    break;
                }
            }
        }
    }
}
