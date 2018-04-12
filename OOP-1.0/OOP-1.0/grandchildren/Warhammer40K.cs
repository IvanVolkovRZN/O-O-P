using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1._0.grandchildren 
{
    class Warhammer40K : children.WarGame


    {
        public override void Rules()
        {
            string rul = ("Книга правил и кодекс для каждой армии");
        }

        public override void Box()
        {

            string  box= ("ящик-переноска для миниатюр");

        }

        public override void Cubes() // размер кубиков для игры в миллиметрах
        {
            int cub = 15; 
        }

        public override void Miniatures() // размер миниатюр для игры в миллиметрах
        {
            int min = 40;    


        }

        public override void Roulette()   //  длинна рулетки для игры (в футах)
        {

            int rul = 6 ; 
                 

        }





    }
}
