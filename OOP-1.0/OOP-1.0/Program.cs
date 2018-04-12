using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1._0
{
   static  class Program
    {
       

        static void Main(string[] args)
        {

            OOP_1._0.grandchildren.Warhammer40K war = new OOP_1._0.grandchildren.Warhammer40K();
            OOP_1._0.grandchildren.Monopoly mon = new OOP_1._0.grandchildren.Monopoly();
            OOP_1._0.grandchildren.Poker pok = new OOP_1._0.grandchildren.Poker();

            war.Rules();
            mon.Cards();
            pok.fishki();

        }
    }
}
