using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1._0.children
{
    class TypeTool : parent.Tool
    {

        protected string Type;

        public TypeTool(string type, string name, int price) : base (name, price)
        {
            this.Type = type;
        }


        public override string ut()
        {
            return Type + " " + Name + " " + Price;
        }

    }
}
