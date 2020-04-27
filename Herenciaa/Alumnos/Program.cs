using System;

namespace Alumnos
{
    class Alumnos
    {
        protected string nombre;
        protected string escuela;

        public Alumnos(string n, string e){
            nombre=n;
            escuela=e;
        }

        public void presentarse(){
            Console.WriteLine("Buenos dias, mi nombre es {0} y estudio en {1}", nombre, escuela);
        }

        public void explica(){
            Console.WriteLine("Yo hago (Tal actividad)");
        }
    }

    class Licenciatura:Alumnos
    {
        protected string carrera;

        public Licenciatura(string nombre, string escuela, string c):base(nombre, escuela){
         carrera=c;
         }

        public new void presentarse(){
         Console.WriteLine("Soy {0} Mi licenciatura es en {1}",nombre, carrera);
        }

        public new void explica(){
         Console.WriteLine("Por el momento hago Servicio social y residencia");
         }
    }

    class Posgrado:Alumnos
    {
        protected string tema;

        public Posgrado(string nombre, string escuela, string t):base(nombre, escuela){
            tema=t;
        }

        public new void presentarse(){
            Console.WriteLine("Buenos dias soy {0} vengo al posgrado", nombre);
        }

        public new void explica(){
            Console.WriteLine("Mi tema de investigacion es {0}",tema);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Alumnos a = new Alumnos ("Juan", "Oxford");
            Licenciatura l = new Licenciatura ("Travis","Mit","Sistemas");
            Posgrado p = new Posgrado ("Kevin","Harvard","Pirateria Informatica");

            a.presentarse();
            a.explica();

            l.presentarse();
            l.explica();

            p.presentarse();
            p.explica();
        }   
    }
}