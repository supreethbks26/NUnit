﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            Icalc c = new Calc();

            Console.WriteLine(c.add("10", "5"));
            Console.ReadLine();
        }
    }
}
