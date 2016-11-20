using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Ksiazka : Publikacja
    {
        private string autor;
        private string wydawnictwo;
        private int rokWydania;
        private int iloscStron;

        public int PodajCene()
        {
            return iloscStron * 2;
        }

        public Ksiazka()
        {
            iloscStron = 0;
        }

        public Ksiazka(string tytul, string autor, string wydawnictwo, int rokWydania, int iloscStron)
            : base(tytul)
        {
            this.autor = autor;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
            this.iloscStron = iloscStron;
        }

        public void UstawAutoraITytul(string autor, string tytul)
        {
            this.autor = autor;
            this.tytul = tytul;
        }

        public void UstawIloscStron(int strony)
        {
            this.iloscStron = strony;
        }
    }
}
