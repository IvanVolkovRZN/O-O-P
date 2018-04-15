using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1._0.grandchildren
{
    class ElectricTools : children.CharacterTool
    {

        protected int Wolt;

        public ElectricTools(int wolt, string character, string name, int price) : base(character, name, price)
        {
            this.Wolt = wolt;
        }


        public override string ut()
        {
            return "подключается к сети " + Wolt + "W, тип - " + Character + ", название - " + Name + ", цена - " + Price + "руб.";



        }
    }
}