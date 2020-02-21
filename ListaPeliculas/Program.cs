using System;
using System.Collections.Generic;

namespace ListaPeliculas
{
    class Peli
    {
        public string nombre;
        
        public void imprime(){
            Console.WriteLine("({0})",nombre);
        }

        public Peli(string p){
            nombre=p;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Peli> pelis= new List<Peli>();
            pelis.Add(new Peli("Real Steel"));
            pelis.Add(new Peli("Cadena de favores"));
            pelis.Add(new Peli("Charlie y la fabrica de chocolates"));
            pelis.Add(new Peli("Interestelar"));
            pelis.Add(new Peli("No manches Frida"));
            
            foreach(Peli p in pelis)
            p.imprime();
        }
    }
}
