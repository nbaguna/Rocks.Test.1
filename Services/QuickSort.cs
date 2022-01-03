using Rocks.Test._1.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rocks.Test._1.Services
{
    public class QuickSort : ISortingStrategy
    {
        public char[] Sort(char[] number, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(number, left, right);

                if (pivot > 1)
                {
                    Sort(number, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Sort(number, pivot + 1, right);
                }
            }
            return number;
        }

        private static int Partition(char[] letter, int left, int right)
        {
            char pivot = letter[left];
            while (true)
            {
                while (letter[left] < pivot)
                {
                    left++;
                }

                while (letter[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (letter[left] == letter[right]) return right;

                    char temp = letter[left];
                    letter[left] = letter[right];
                    letter[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
