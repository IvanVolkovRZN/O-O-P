using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1._0.grandchildren
{
    class SaskingTools : children.CharacterTool
    {

        protected int CuttingSurfaceSize;

    public SaskingTools(int cuttingSurfaceSize, string character, string name, int price) : base(character, name, price)
    {
        this.CuttingSurfaceSize = cuttingSurfaceSize;
    }


    public override string ut()
    {
        return "режущая поверхность = " + CuttingSurfaceSize + "мм, тип - " + Character + ", название - " + Name + ", цена - " + Price + "руб.";
            


    }
}
}
