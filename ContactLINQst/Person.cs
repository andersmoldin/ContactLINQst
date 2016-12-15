using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactLINQst
{
    class Person
    {
        public string Namn { get; set; }
        public DateTime NameDay { get; set; }

        public Person(string namn, DateTime nameDay)
        {
            Namn = namn;
            NameDay = nameDay;
        }
    }
}
