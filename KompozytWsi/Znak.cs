using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompozytWsi
{
    class Znak : Element
    {
        private char c;

        public Znak(char c)
        {
            this.c = c;
        }
        public override void drukuj()
        {
            Console.Write(c);
        }
    }
}
