using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1._0.children
{
    class SaskingTools : parent.Tool
    {

        protected string Purpose;

        public SaskingTools(string purpose, string name, int price) : base (name, price)
        {
            this.Purpose = purpose;
        }


        public override string Info()
        {
            return Purpose + " " + Name + " " + Price;
        }

    }
}
