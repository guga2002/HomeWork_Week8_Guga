using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace HomeWork_Week8_Guga.Meore_Davaleba
{
    public class Saxeli_mis
    {
        protected string myName="guga";
        protected string misamarti = "Ilia chavchavadze avenue N37";
        public Saxeli_mis(string myName,string misamarti) 
        {
            this.myName = myName;
            this.misamarti = misamarti;
        }
        public Saxeli_mis() { }

        public override string ToString()//memkvidre klashi gamoviyeneb
        {
            return $"Name : {myName}; Misamarti: {misamarti} \t"; 
        }
    }
}
