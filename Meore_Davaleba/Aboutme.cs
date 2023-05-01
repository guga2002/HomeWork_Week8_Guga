using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Week8_Guga.Meore_Davaleba
{
    public class Aboutme:Saxeli_mis
    {
        private DateTime dt = new DateTime(2002, 02, 20);
        private byte age = 21;

        public Aboutme(string myName, string misamarti,DateTime dt, byte age):base(myName,misamarti)
        {
            this.dt = dt;
            this.age = age;
        }
        public Aboutme() { }
        public override string ToString()
        {
            return $"{base.ToString()}; Datatime:{dt.ToString()};Age:{age} \n";
        }
        public void printaboutme()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
