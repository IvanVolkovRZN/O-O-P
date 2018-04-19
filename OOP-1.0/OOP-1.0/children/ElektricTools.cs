using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1._0.children
{
    class ElektricTools : parent.Tool
    {

        protected int Power;

        public ElektricTools(int power, string name, int price) : base(name, price)
        {
            this.Power = power;
        }


        public override string Info()
        {
            return Power + " " + Name + " " + Price;
        }
    }
}
