﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass cls = new MyClass("dog");
            Console.Write(cls.ToString());
            Console.Read();
        }
    }
}