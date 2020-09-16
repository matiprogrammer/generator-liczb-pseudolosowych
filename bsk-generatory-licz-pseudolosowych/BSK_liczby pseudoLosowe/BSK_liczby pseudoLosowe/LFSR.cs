using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSK_liczby_pseudoLosowe
{
    public class LFSR
    {
        int[] seed;
        int[] polynomial;


        public LFSR(string polynomialText, string seedText)
        {
            seed = ConvertSringToIntTable(seedText);
            polynomial = ConvertSringToIntTable(polynomialText);


        }

        public string GenerateNext()
        {
            int[] nextValue = null;
            nextValue = seed.ToArray();


            for (int i = polynomial.Length - 1; i > 0; i--)
            {
                nextValue[i] = nextValue[i - 1];
            }
            var a = nextValue;
            int temp = 0;

            for (int i = 0; i < polynomial.Length; i++)
            {
                if (polynomial[i] == 1 && seed[i] == 1)
                    temp++;
            }
            temp = temp % 2;

            if (temp == 0)
                temp = 0;
            else
                temp = 1;
            nextValue[0] = temp;

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < polynomial.Length; i++)
            {
                result.Append(nextValue[i]);

            }
            seed = nextValue;
            return result.ToString();

        }

        private int[] ConvertSringToIntTable(string inputString)
        {
            int[] temp = new int[inputString.Length];
            for (int i = 0; i < inputString.Length; i++)
            {
                temp[i] = int.Parse(inputString[i].ToString());
            }
            return temp;
        }

    }
}
