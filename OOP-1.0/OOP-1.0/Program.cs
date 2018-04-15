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
            SaskingTools tool_1 = new SaskingTools(200, "раскроечный инструмент", "лобзик", 380);
            Console.WriteLine(tool_1.ut());

            ElectricTools tool_2 = new ElectricTools(220, "электро инструмен", "Шуруповерт", 3720);
            Console.WriteLine(tool_2.ut());

            
            Console.ReadLine();
        }







    }
}
