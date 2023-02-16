using System;
using System.Collections.Generic;
using System.Linq;
// Language integrated query
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasis
{
    internal class FunksioneMeLista
    {

        public int GjejMeTeMadhinNeListe(List<int> lista)
        {
            return lista.Max();
        }

        public int GjejShumenEListes(List<int> lista)
        {
            return lista.Sum();
        }

        
        public int GjejShumenCiftNeListe(List<int> lista)
        {
        
            // lambda expression
            return lista.Where(el => el % 2 == 0).Sum();

            // a(e pare)  ---- > krijohet referenca e elementit ne liste
            // => ---- > ku 
            // a(e dyte)  ---- > vet elementi te cilit po i referohemi
        }

    }
}
            