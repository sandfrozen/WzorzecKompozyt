using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompozytWsi
{
    class Program
    {
        static void Main(string[] args)
        {
            Dokument d = new Dokument("Ostatni Liter", "Pan Tadeusz");
            Rozdzial r1 = new Rozdzial("Pierwsza połówka");
            Rozdzial r2 = new Rozdzial("Druga połówka");
            d.dodaj(r1);
            d.dodaj(r2);
            Akapit a1 = new Akapit();
            Akapit a2 = new Akapit();
            Akapit a3 = new Akapit();
            a1.dodaj("Zaczeło się niewinnie... Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam auctor finibus metus, et efficitur lacus consequat sed. Donec nulla dui, lacinia ut nisi vel, tincidunt imperdiet mauris. Etiam vitae sollicitudin mauris, nec scelerisque lacus. Nam nec tortor dapibus, semper felis nec, commodo metus. Nullam dapibus vitae elit sed vehicula. Suspendisse urna purus, maximus nec sapien non, vestibulum facilisis libero. Nunc non placerat eros.");
            a2.dodaj("To już było pewne... Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam auctor finibus metus, et efficitur lacus consequat sed. Donec nulla dui, lacinia ut nisi vel, tincidunt imperdiet mauris. Etiam vitae sollicitudin mauris, nec scelerisque lacus. Nam nec tortor dapibus, semper felis nec, commodo metus. Nullam dapibus vitae elit sed vehicula. Suspendisse urna purus, maximus nec sapien non, vestibulum facilisis libero. Nunc non placerat eros.");
            r1.dodaj(a1);
            r1.dodaj(a2);
            a3.dodaj("Tego się nikt nie spodziewał... Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam auctor finibus metus, et efficitur lacus consequat sed. Donec nulla dui, lacinia ut nisi vel, tincidunt imperdiet mauris. Etiam vitae sollicitudin mauris, nec scelerisque lacus. Nam nec tortor dapibus, semper felis nec, commodo metus. Nullam dapibus vitae elit sed vehicula. Suspendisse urna purus, maximus nec sapien non, vestibulum facilisis libero. Nunc non placerat eros.");
            r2.dodaj(a3);
            d.drukuj();
        }
    }
}
