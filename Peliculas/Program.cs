using System;

namespace Peliculas
{
    class peliculas
    {
        public string titulo;
        public int año;
        public string pais;
        public string director;


    }
    class Program
    {
        static void Main(string[] args)
        {
            peliculas p1= new peliculas();
            p1.titulo=("Titanic ");
            p1.año=1997;
            peliculas p2= new peliculas();
            p2.titulo=("Forrest Gump ");
            p2.año=1994;
            Console.Write(p1.titulo);
            Console.WriteLine(p1.año);
            Console.Write(p2.titulo);
            Console.WriteLine(p2.año);
        }
    }
}
