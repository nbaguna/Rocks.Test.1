using System;
using System.Collections.Generic;
using System.Text;

namespace Rocks.Test._1.Services.Interface
{
    public interface ISortingStrategy
    {
         char[] Sort(char[] number, int left, int right);
    }
}
