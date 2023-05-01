using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Week8_Guga.Mesame
{
    public class Parentof
    {
   
        public Parentof(string ID_number)
        {
            this.ID_number=ID_number;
            unique();
        }

        protected String ID_number { get; set; }
        int unk;

        ISet<int> seti = new HashSet<int>();


        private void unique()
        {
            Random rnd = new Random();
            unk = rnd.Next(1, 1000);
            while (seti.Contains(unk))
            {
                unk = rnd.Next(1, 1000);
            }
        }
               
            
        public override string ToString()
        {
            return $"Id is {ID_number} unique Qr is:{unk}";
        }
    }
}
