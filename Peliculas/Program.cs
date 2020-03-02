using System;
using System.Collections.Generic;

namespace Peliculas
{
    class peliculas
    {
        private string titulo;
        private int año;
        private string pais;
        private string director;
        private string actores;
        private int nacimiento;


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

        public peliculas(string t, int a, string p, string d){
            titulo=t;
            año=a;
            pais=p;
            director=d;
        }

        public void imprime(){
        Console.WriteLine("{0}({1}) País: {2} Dirigida Por: {3}", getTitulo(), getAño(), getPais(), getDirector());
        }


        public peliculas(string act, int nac){
            actores=act;
            nacimiento=nac;
        }

        public void impActores(){
            Console.WriteLine("Actor principal:{0}({1})",actores, nacimiento);
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            List<peliculas> pelis= new List<peliculas>();

            pelis.Add(new peliculas ("Leonardo DiCaprio", 1974));
            pelis.Add(new peliculas ("Tom Hanks", 1956));

            peliculas p1= new peliculas("Titanic",1997,"Estados Unidos","James Cameron");
            p1.imprime();
            pelis[0].impActores();

            peliculas p2= new peliculas("Forrest Gump", 1994,"Estados Unidos","Robert Zemeckis");
            p2.imprime(); 
            pelis[1].impActores();


            
        }
    }
}
