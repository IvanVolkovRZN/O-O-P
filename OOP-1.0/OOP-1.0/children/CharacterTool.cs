using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1._0.children
{
    class CharacterTool : parent.Tool
    {

        protected string Character;

        public CharacterTool(string character, string name, int price) : base (name, price)
        {
            this.Character = character;
        }


        public override string ut()
        {
            return Character + " " + Name + " " + Price;
        }

    }
}
