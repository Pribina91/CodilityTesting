using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Tst
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var FirstNames = new List<string>() {"Bob", "Sondra", "Avery", "Von", "Randle", "Gwen", "Paisley"};
            var LastNames = new List<string>() {"Anderson", "Carlson", "Vickers", "Black", "Schultz", "Marigold", "Johnson"};
            var Birthdates = new List<DateTime>()
            {
                Convert.ToDateTime("11/12/1980"),
                Convert.ToDateTime("09/16/1978"),
                Convert.ToDateTime("05/18/1985"),
                Convert.ToDateTime("10/29/1980"),
                Convert.ToDateTime("01/19/1989"),
                Convert.ToDateTime("01/14/1972"),
                Convert.ToDateTime("02/20/1981")
            };

            var resultList = new List<Tst>();
            for (int i = 0; i < FirstNames.Count; i++)
            {
                resultList.Add(
                    new Tst()
                    {
                        Id = i,
                        Name = FirstNames[i]
                    }
                );
            }
        }
    }
}