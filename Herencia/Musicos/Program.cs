using System;
using System.Collections.Generic;

namespace Musicos
{
    class Musicos
    {
        protected string nombre;

        public Musicos(string n){
            nombre=n;
        }

        public void afina(){
            Console.WriteLine("Denme un segundo");

        }

        public void saluda(){
            Console.WriteLine("Hola a todos! Aqui {0}", nombre);
        }

        public void toca(){
            Console.WriteLine("Vamos a darle!");
        }

    }

    class Baterista:Musicos
    {
        protected string bateria;

        public Baterista(string nombre, string bateria):base(nombre){
            this.bateria=bateria;
        }

        public new void afina(){
            Console.WriteLine("Batumps!");

        }

        public new void saluda(){
            Console.WriteLine("Aqui {0} mi bateria es {1}",nombre, bateria);
        }

        public new void toca(){
            Console.WriteLine("Pum! Pum! Pum!");
        }
    }

    class Bajista:Musicos{
         protected string bajo;

        public Bajista(string nombre, string b):base(nombre){
            bajo=b;
        }
        
        public new void afina(){
            Console.WriteLine("Tum...");

        }

        public new void saluda(){
            Console.WriteLine("Aqui {0} mi bajo es un {1}",nombre, bajo);
        }

        public new void toca(){
            Console.WriteLine("Tan tan");
        }
    }

    class Guitarrista:Musicos{
         protected string guitarra;

        public Guitarrista(string nombre, string g):base(nombre){
            guitarra=g;
        }

        public new void afina(){
            Console.WriteLine("Pam Pam Pam");

        }

        public new void saluda(){
            Console.WriteLine("Yo soy {0} mi guitarra es {1} y nosotros somos Hombres P",nombre, guitarra);
        }

        public new void toca(){
            Console.WriteLine("Pam Pam tananananana pam pam");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Baterista a= new Baterista ("Jojo", "10 piezas");
            List<Musicos> musico = new List<Musicos>();
            musico.Add(new Musicos("Joserroni"));
            musico.Add(new Baterista("Elise","12 piezas"));
            musico.Add(new Bajista("Slash","Gibson"));
            musico.Add(new Guitarrista("Jimmy","Fender"));

            foreach(Musicos m in musico){
                m.afina();
                m.saluda();
                m.toca();
            }

            a.afina();
            a.saluda();
            a.toca();

            
        
        }
    }
}
