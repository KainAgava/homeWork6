﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberGrandmothers;
            int timeToServe;

            Console.WriteLine("сколько в очереди бабушек? ");
            numberGrandmothers = Convert.ToInt32(Console.ReadLine());
            timeToServe = numberGrandmothers;

            int fixedReceptionTime = 10 * timeToServe;
            int minute = fixedReceptionTime % 60;
            int hour = fixedReceptionTime / 60;
       
            Console.WriteLine($"Вы должны отстоять в очереди {hour} часа и {minute} минут.");

        }
    }
}
