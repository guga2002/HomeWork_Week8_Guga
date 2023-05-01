using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Week8_Guga.Classes
{
   public class Parent
    {
        #region Constructors
        public Parent()
        {
            //aq  daiwereba konstruqtoris logika
        }
        #endregion

        #region Methods

        protected int calculateSumFromConsole()
        {
            //sanam ricxvebs shemoitans manam daiwereba ricxvebis namravli
            int number ;
            int namravli = 1;
            Console.WriteLine("Rigrigobit shemoitane ricxvi yovel jerze wina jami gamravldeba shemotanil ricxvze");
            Console.WriteLine("programis dasasruleblad akrifet integer araswori formatit ,for example : 2d4 ");
            while (int.TryParse(Console.ReadLine(),out number))
            {
                namravli += number;
            }
            Console.WriteLine( $"Ricxvebis namravli aris {namravli} \n");
            return namravli;
        }
        #endregion
    }
}
