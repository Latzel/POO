using System;

namespace Peliculas
{
    class peliculas
    {
        private string titulo;
        private int año;
        private string pais;
        private string director;

        public string getTitulo(){
            return titulo;
        }

        public void setTitulo(string t){
            titulo=t;
        }

        public int getAño(){
            return año;
        }

        public void setAño(int a){
            año=a;
        }

        public string getPais(){
            return pais;
        }

        public void setPais(string p){
            pais=p;
        }

        public string getDirector(){
            return director;
        }
        public void setDirector(string d){
            director=d;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            peliculas p1= new peliculas();
            p1.setTitulo("Titanic");
            p1.setAño(1997);
            p1.setPais("Estados Unidos");
            p1.setDirector("James Cameron");
            Console.WriteLine("{0}({1}) Pais: {2} Dirgida Por {3}", p1.getTitulo(), p1.getAño(), p1.getPais(), p1.getDirector());

            peliculas p2= new peliculas();
            p2.setTitulo("Forrest Gump");
            p2.setAño(1994);
            p2.setPais("Estados Unidos");
            p2.setDirector("Robert Zemeckis");
            Console.WriteLine("{0}({1}) Pais: {2} Dirigida Por {3}", p2.getTitulo(), p2.getAño(), p2.getPais(), p2.getDirector());
            
            
            
        }
    }
}
