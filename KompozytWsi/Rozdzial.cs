using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompozytWsi
{
    class Rozdzial : Element
    {
        private String Tytul;
        private LinkedList<Akapit> Akapity = new LinkedList<Akapit>();

        public Rozdzial(String tytul)
        {
            Tytul = tytul;
        }

        public void dodaj(Akapit a)
        {
            Akapity.AddLast(a);
        }

        public override void drukuj()
        {
            Console.WriteLine("\n------------------\n" + Tytul +"\n------------------\n");
            foreach (Akapit a in Akapity)
            {
                a.drukuj();
            }
        }
    }
}
