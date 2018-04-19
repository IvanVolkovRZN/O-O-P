using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1._0.parent
{
    abstract class Tool : IComparable
    {

        protected string Name;
        public int Price;

        protected Tool(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public int CompareTo(object obj)
        {
                var tool = (Tool)obj;
                return Price - tool.Price;
        }

        public abstract string Info();



        public void PrintInfo()
        { 
            Console.WriteLine(Info());
        }




    }
}
