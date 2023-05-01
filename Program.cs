using HomeWork_Week8_Guga.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork_Week8_Guga.Classes;
using HomeWork_Week8_Guga.Meore_Davaleba;
using HomeWork_Week8_Guga.Mesame;

namespace HomeWork_Week8_Guga
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //pirveli
                #region Pirveli
                Child child = new Child();
                int sum = child.calculateSumFromConsole();
                Console.WriteLine("Jami aris " + sum + "\n");
                #endregion

                //meore
                #region Meore
                Aboutme btm = new Aboutme();
                btm.printaboutme();
                //meore varianti ;
                Console.WriteLine(btm);
                #endregion

                //mesame
                #region Mesame
                First frst = new First("45667456", "GUGA", "Chavchavadzis 37");
                Second scnd = new Second("45667465", 21, new DateTime(2002, 02, 20));
                Third thrd = new Third("345667643", "Georgia", "Tbilisi");
                Console.WriteLine(frst);
                Console.WriteLine(scnd);
                Console.WriteLine(thrd);
                #endregion
            }
            catch (Exception exp )
            {

                Console.WriteLine(exp.Message);
            }
            



        }
    }
}
