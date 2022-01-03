using Rocks.Test._1.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rocks.Test._1.Controller
{
    public class SortingController
    {
        private ISortingStrategy sortingStrategy;
        public SortingController(ISortingStrategy sortingStrategy)
        {
            this.sortingStrategy = sortingStrategy;
        }

        public char[] NumberSortingController(char[] number)
        {
            var result = this.sortingStrategy.Sort(number, 0, number.Length - 1);
            return result;
        }
    }
}
