using Rocks.Test._1.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rocks.Test._1.Services
{
    public class BubbleSort : ISortingStrategy
    {
        public char[] Sort(char[] number, int left, int right)
        {
            for (int j = 0; j < number.Length - 1; j++)
            {
                char temp;
                int counter = 0;

                for (int i = 0; i < number.Length - 1; i++)
                {
                    if (number[i] > number[i + 1])
                    {
                        temp = number[i];
                        number[i] = number[i + 1];
                        number[i + 1] = temp;
                        counter++;
                    }
                }
                if (counter == 0)
                {
                    j = number.Length + 1;
                }
            }
            return number;
        }
    }
}
