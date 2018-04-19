﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1._0.grandchildren
{
    class Chisel : children.SaskingTools
    {

        protected int CuttingSurfaceSize;

    public Chisel(int cuttingSurfaceSize, string type, string name, int price) : base(type, name, price)
    {
        this.CuttingSurfaceSize = cuttingSurfaceSize;
    }


    public override string Info()
    {
        return "режущая поверхность = " + CuttingSurfaceSize + "мм, назначение - " + Purpose + ", название - " + Name + ", цена - " + Price + "руб.";
            


    }
}
}
