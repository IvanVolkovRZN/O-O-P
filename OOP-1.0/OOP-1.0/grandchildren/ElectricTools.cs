using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1._0.grandchildren
{
    class ElectricTools : children.TypeTool
    {

        protected int Wolt;

        public ElectricTools(int wolt, string type, string name, int price) : base(type, name, price)
        {
            this.Wolt = wolt;
        }


        public override string ut()
        {
            return "подключается к сети " + Wolt + "W, тип - " + Type + ", название - " + Name + ", цена - " + Price + "руб.";



        }
    }
}