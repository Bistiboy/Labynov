using System;
using System.Collections.Generic;
using System.Text;

namespace Labynov
{
    public class Dalton : Personnage
    {
        public Dalton(int x, int y) : base(x, y)
        {
        }

        public Dalton(int x, int y, string name) : base(x, y, name)
        {
            this.signe = "o";
        }
    }
}
