using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Week8_Guga.Mesame
{
    internal class First:Parentof
    {
        private string Name;
        private string address;

        public First(string ID_number,String name,string address) : base(ID_number)
        {
            Name = name;
            this.address = address;
        }

        public override string ToString()
        {
            return $"{base.ToString()} ; Name:{Name} ; address: {address} \n";
        }
    }
}
