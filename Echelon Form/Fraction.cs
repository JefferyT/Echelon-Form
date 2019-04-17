using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echelon_Form
{
    class Fraction
    {
        private int numerator;
        private int denominator;
        public Fraction(bool pos, int num, int denom)
        {
            numerator = num;
            denominator = denom;
        }

        public Fraction(string frac)
        {
            string[] fraction = frac.Split('/');
            int[] fractionInts = Array.ConvertAll(fraction, int.Parse);
            numerator = fractionInts[0];
            if (fraction.Count() == 2)
            {
                denominator = fractionInts[1];
            }
        }

        private Dictionary<int, int> Factor(int num)
        {
            Dictionary<int, int> ret = new Dictionary<int, int>();
            int i = 2;
            while (num >= i)
            {
                if (num%i==0)
                {
                    int count = 0;
                    if (ret.TryGetValue(i, out count))
                    {
                        ret.Remove(i);
                    }
                    ret.Add(i, count);
                } else
                {
                    i++;
                }
            }
            return ret;
        }

        private int Unfactor(Dictionary<int, int> factors)
        {
            int i = 1;
            foreach (int factor in factors.Keys)
            {
                int power = 0;
                factors.TryGetValue(factor, out power);
                i *= (int) Math.Pow(factor, power);
            }
            return i;
        }

        private void Simplify()
        {
            Dictionary<int, int> numFac = Factor(numerator);
            Dictionary<int, int> denFac = Factor(denominator);

        }
    }
}
