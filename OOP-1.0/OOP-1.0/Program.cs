using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_1._0.grandchildren;
using OOP_1._0.parent;


namespace OOP_1._0
{
     class Program 
    {
        public static object SendKeys { get; private set; }

        public static void Main(string[] args)
        {



            Start();
            CollectionsTask();
        }


        protected static void Start()
        {
            FretSaw tool_1 = new FretSaw(200, "раскроечный инструмент", "лобзик", 380);
            Console.WriteLine(tool_1.Info());

            HammerDrill tool_2 = new HammerDrill("AEG", 230, "Перфоратор", 7720);
            Console.WriteLine(tool_2.Info());

            Chisel tool_3 = new Chisel(20, "фигурная обработка", "Стамеска", 170);
            Console.WriteLine(tool_3.Info());

            BuildingDryer tool_4 = new BuildingDryer("Makita", 280, "Строительный фен", 5900);
            Console.WriteLine(tool_4.Info());

            Console.ReadLine();
        }


        // после этого коменария идет работа с коллекциями


        protected static void CollectionsTask()
        {


            HammerDrill hammerDrill = new HammerDrill("AEG", 230, "Перфоратор", 7720);
            hammerDrill.Info();

            FretSaw fretSaw = new FretSaw(200, "раскроечный инструмент", "лобзик", 380);
            fretSaw.Info();

            Chisel chisel = new Chisel(20, "фигурная обработка", "Стамеска", 170);
            chisel.Info();

            BuildingDryer bildingDryer = new BuildingDryer("Makita", 280, "Строительный фен", 5900);
            bildingDryer.Info();


            


            List<Tool> objList = new List<Tool>();

            objList.Add(hammerDrill);

            objList.Add(fretSaw);

            objList.Add(chisel);

            objList.Add(bildingDryer);

            objList.Sort(); // обычная сортировка  вариант №1
 
            //objList = objList.OrderBy(o => o.Price).ToList(); // варант сортировки №2

            //objList.Sort((x, y) => x.Price.CompareTo(y.Price));  // сортировка Лямбда  вариант №3


            objList.ForEach(t => t.PrintInfo());
            Console.ReadLine();
        }



    }
}
