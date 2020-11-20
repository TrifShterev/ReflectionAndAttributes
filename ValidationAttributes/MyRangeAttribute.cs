using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private int _min;
        private int _max;

        public MyRangeAttribute(int min, int max)
        {
            _min = min;
            _max = max;
        }

        public override bool IsValid(object obj)
        {
            if (!(obj is int))
            {
                throw new ArgumentException("Invalid argument");
            }

            int valueAsInt = (int)obj;

            if (valueAsInt>=_min &&valueAsInt<=_max)
            {
                return true;
            }
            return false;
        }
    }
}
