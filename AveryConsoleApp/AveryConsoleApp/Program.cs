﻿using AveryBL;
using System;

namespace AveryConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Utility util = new Utility();
            int sum =util.Add(5, 6);
            Console.WriteLine(sum);

        }
    }
}
