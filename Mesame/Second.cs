using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Week8_Guga.Mesame
{
    internal class Second:Parentof
    {
        private byte age;
        private DateTime birth;

        public Second(string ID_number,byte  age, DateTime birth) : base(ID_number)
        {
            this.age = age;
            this.birth = birth;
        }

        public override string ToString()
        {
            return $"{base.ToString()}; Age:{age} ; Birthday:{birth.ToString()} \n ";
        }
    }
}
