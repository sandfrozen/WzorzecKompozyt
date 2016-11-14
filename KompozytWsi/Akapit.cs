using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompozytWsi
{
    class Akapit : Element
    {
        private LinkedList<Znak> Znaki = new LinkedList<Znak>();

        public void dodaj(Znak z)
        {
            Znaki.AddLast(z);
        }

        public void dodaj(String s)
        {
            char[] zn = s.ToCharArray();
            foreach(char c in zn)
            {
                dodaj(new Znak(c));
            }
        }
        public override void drukuj()
        {
            Console.Write("\t");
            foreach (Znak z in Znaki)
            {
                z.drukuj();
            }
            Console.Write("\n\n");
        }
    }
}
