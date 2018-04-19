using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_1._0.grandchildren;

namespace OOP_1._0
{
     class Program
    {
       

        public static void Main(string[] args)
        {



            Start();

        }


        protected static void Start()
        {
            FretSaw tool_1 = new FretSaw(200, "раскроечный инструмент", "лобзик", 380);
            Console.WriteLine(tool_1.ut());

            HammerDrill tool_2 = new HammerDrill("AEG", 230, "Перфоратор", 7720);
            Console.WriteLine(tool_2.ut());

            
            Console.ReadLine();
        }







    }
}
