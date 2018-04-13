using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1._0
{
     class Program
    {
       static OOP_1._0.grandchildren.Warhammer40K war = new OOP_1._0.grandchildren.Warhammer40K();
        static OOP_1._0.grandchildren.Monopoly mon = new OOP_1._0.grandchildren.Monopoly();
        static OOP_1._0.grandchildren.Poker pok = new OOP_1._0.grandchildren.Poker();

        public static void Main(string[] args)
        {



            Object();

        }


        protected static void Object()
        {
            war.Rules();
            mon.Cards();
            pok.fishki();
        }







    }
}
