using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompozytWsi
{
    class Dokument : Element
    {
        public String Tytul { get; set; }
        public String Autor { get; set; }
        private LinkedList<Rozdzial> rozdzialy = new LinkedList<Rozdzial>();

        public Dokument(String t, String a)
        {
            this.Tytul = t;
            this.Autor = a;
        }

        public void dodaj(Rozdzial r)
        {
            rozdzialy.AddLast(r);
        }

        public override void drukuj()
        {
            Console.WriteLine("\n*** " + Tytul + " ***\n\n");
            Console.WriteLine("(c) \"" + Autor+"\"\n");
            foreach (Rozdzial r in rozdzialy)
            {
                r.drukuj();
            }
        }
    }
}
