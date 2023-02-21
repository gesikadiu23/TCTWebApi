﻿using System;
using System.Collections.Generic;
using System.Linq;
// Language integrated query
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasis.Test
{
    internal class FunksioneMeLista
    {

        /// <summary>
        /// Pret nje liste me integer
        /// </summary>
        /// <param name="lista"></param>
        /// <returns>Kthen numrin me te madh te listes</returns>
        public int GjejMeTeMadhinNeListe(List<int> lista)
        {
            return lista.Max();
        }

        /// <summary>
        /// Pret nje liste me integer
        /// </summary>
        /// <param name="lista"></param>
        /// <returns>Kthen shumen e elementeve te listes</returns>
        public int GjejShumenEListes(List<int> lista)
        {
            return lista.Sum();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="lista"></param>
        /// <returns></returns>
        public int GjejShumenCiftNeListe(List<int> lista)
        {

            // lambda expression
            return lista.Where(el => el % 2 == 0).Sum();

            // a(e pare)  ---- > krijohet referenca e elementit ne liste
            // => ---- > ku 
            // a(e dyte)  ---- > vet elementi te cilit po i referohemi
        }


        public int GjejSasineEElementevePozitiv(List<int> lista)
        {
            return lista.Where(a => a >= 0).Count();
        }

        // ndertoni nje funksion qe merr si input nje liste dhe kthen numrin
        // e elementeve pozitiv te listes

        /// <summary>
        /// Merr nje liste me integer
        /// </summary>
        /// <param name="lista"></param>
        /// <returns>Kthen vetem elementet tek te listes</returns>
        public List<int> KtheElementetTek(List<int> lista)
        {
            return lista.Where(a => a % 2 == 1).ToList();
        }

        public List<string> KonvertoUppercase(List<string> lista)
        {
            return lista.Select(a => a.ToUpper()).ToList();
        }

        public int ShumaNegative(List<int> lista)
        {
            return lista.Where(b => b < 0).Sum();
        }


        public List<int> KtheNumratPozitivCift(List<int> lista)
        {
            int a = 10;

            if (a > 0 && a % 2 == 0)
            {

            }

            return lista.Where(a => a > 0 && a % 2 == 0).ToList();
        }


    }   // ndertoni nje funksion qe merr si input nje liste
        // dhe kthen vetem elementet tek te kesaj liste



}