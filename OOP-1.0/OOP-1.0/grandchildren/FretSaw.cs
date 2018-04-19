using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1._0.grandchildren
{
    class FretSaw : children.SaskingTools
    {

        protected int CuttingSurfaceSize;

    public FretSaw(int cuttingSurfaceSize, string type, string name, int price) : base(type, name, price)
    {
        this.CuttingSurfaceSize = cuttingSurfaceSize;
    }


    public override string ut()
    {
        return "режущая поверхность = " + CuttingSurfaceSize + "мм, назначение - " + Purpose + ", название - " + Name + ", цена - " + Price + "руб.";
            


    }
}
}
