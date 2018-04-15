using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1._0.grandchildren
{
    class SaskingTools : children.TypeTool
    {

        protected int CuttingSurfaceSize;

    public SaskingTools(int cuttingSurfaceSize, string type, string name, int price) : base(type, name, price)
    {
        this.CuttingSurfaceSize = cuttingSurfaceSize;
    }


    public override string ut()
    {
        return "режущая поверхность = " + CuttingSurfaceSize + "мм, тип - " + Type + ", название - " + Name + ", цена - " + Price + "руб.";
            


    }
}
}
