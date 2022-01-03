using System;
using System.Collections.Generic;
using System.Text;

namespace Rocks.Test._1.Specification
{
    public class NumberSpecification : INumberSpecification
    {
        public bool IsSatisfiedBy(string input)
        {
            int number;
            try
            {
                return int.TryParse(input, out number);
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
