using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1._0.grandchildren
{
    class HammerDrill : children.ElektricTools
    {

        protected string Brand;

        public HammerDrill(string brand, int power, string name, int price) : base(power, name, price)
        {
            this.Brand = brand;
        }


        public override string ut()
        {
            return "Название фирмы производителя - " + Brand + ", мощность - " + Power + "Вт, название - " + Name + ", цена - " + Price + "руб.";



        }
    }
}