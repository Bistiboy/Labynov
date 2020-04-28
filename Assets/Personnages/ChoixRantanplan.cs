using System;
using System.Collections.Generic;
using System.Text;

namespace Labynov
{
    public class ChoixRantanplan
    {
        public string direction { get; set; }

        public Case @case { get; set; }

        public ChoixRantanplan(string direction , Case @case)
        {
            this.direction = direction;
            this.@case = @case;
        }
    }
}
