using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echelon_Form
{
    public class AugmentedMatrix
    {
        private int[][] matrix;
        public AugmentedMatrix(int n, int m, string[] rows)
        {
            foreach(string row in rows)
            {
                string[] values = row.Split(' ');

                int[] valuesInRow = Array.ConvertAll(values, int.Parse);
            }
        }
    }
}
