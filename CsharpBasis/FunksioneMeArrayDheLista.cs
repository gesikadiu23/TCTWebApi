using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasis
{
    internal class FunksioneMeArrayDheLista
    {
        public int GjejMeTeMadhin(int[] array){

            int max = 0;

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
            }

            return max;
        }

        public int GjejShumenEArray(int[] array) {
            
            int sum = 0;

            for (int i = 0; i< array.Length; i++)
            {
                sum = sum + array[i];
            }
            
            return sum;

        }
    }
}
