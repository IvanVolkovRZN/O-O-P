using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1._0.parent
{
   abstract class Tool
    {

        protected string Name;
        protected int Price;

        protected Tool(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public virtual void Rules(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

        public abstract string ut();


    }
}
