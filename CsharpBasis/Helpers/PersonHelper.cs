using CsharpBasis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasis.Helpers
{
    internal class PersonHelper
    {
        /// <summary>
        /// Merr si input Nje liste me persona
        /// </summary>
        /// <param name="persons"></param>
        /// <returns>Personat e renditur sipas moshes, emrit, mbiemrit, adreses</returns>
        public List<Person> RenditPersonatSipasMoshes(List<Person> persons)
        {
            return persons.OrderBy(a => a.Age).ThenBy(b => b.Name).ThenBy(b => b.Surname).ToList();
        }

        /// <summary>
        /// Merr si input nje liste me persona
        /// </summary>
        /// <param name="persons"></param>
        /// <returns>Kthen moshen mesatare te personave</returns>
        public double GjejMoshenMesatare(List<Person> persons)
        {
            return persons.Average(a => a.Age);
        }


        /// <summary>
        /// Merr si input nje liste me persona
        /// </summary>
        /// <param name="persons"></param>
        /// <returns>Kthen personin me moshen me te madhe</returns>
        public Person KthePersoninMeTeMadh(List<Person> persons)
        {
            return persons.MaxBy(a => a.Age);
        }



    }
}
