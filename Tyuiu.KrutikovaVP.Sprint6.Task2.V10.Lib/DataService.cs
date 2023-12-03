﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KrutikovaVP.Sprint6.Task2.V10.Lib
{
    public class DataService : ISprint6Task2V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x - 0.7 != 0)
                {
                    y = Math.Round(2*x-4+(2*x-1)/(Math.Sin(x)+1), 2);
                    valueArray[count] = y;
                    count++;
                }
                else
                {
                    y = 0;
                    valueArray[count] = y;
                    count++;
                }

            }
            return valueArray;
        }
    }
}