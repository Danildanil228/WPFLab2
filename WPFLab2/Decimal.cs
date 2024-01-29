using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NumberConversionApp
{
    public class DecimalNumber : INumber
    {
        private readonly int value;

        public DecimalNumber(int value)
        {
            this.value = value;
        }

        public string ConvertToDecimal()
        {
            return value.ToString();
        }

        public string ConvertToBinary()
        {
            return System.Convert.ToString(value, 2);
        }
    }
}
