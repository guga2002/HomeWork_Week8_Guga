using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Week8_Guga.Mesame
{
    public class Third:Parentof
    {
        private string country;
        private string city;

        public Third(string ID_number,string country , string city) : base(ID_number)
        {
            this.country = country;
            this.city = city;
        }
        public override string ToString()
        {
            return $"{base.ToString()}; country:{country} ; city: {city} \n";
        }
    }
}
