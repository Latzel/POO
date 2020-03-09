using System;
using System.Collections.Generic;

namespace Parametros
{

    class Persona
    {
        public string nombre;
        public string apellido;

        public Persona(){
            nombre="Menganito";
            apellido="Perez";
        }
    }

    class Anonimo
    {
        public static void Anonimiza(Persona p){
            p.nombre="XXXXXX";
            p.apellido="XXXXXX";
        }

        public static void Cambiar(ref Persona p){
            p= new Persona();
            p.nombre="Nuevo";
        }
    }
    
    class Program
    {
        static void Duplicar(int x){
            x=x*2;
        }

        static int Sumar(int x, int y){
            return x+y;
        }

        static void Sumar(int x, int y, out int res){
            res=x-y;
        }

        static void Main(string[] args)
        {
            int a=2;
            int b=4;
            int r= Sumar(a,b);
            int r2;
            Sumar(r,a, out r2);
            Console.WriteLine(r2);

            //Duplicar(ref a);
            Persona p= new Persona();
            Console.WriteLine(p.nombre);
            Anonimo.Anonimiza(p);
            //Anonimo.Cambiar(ref p);
            Console.WriteLine(p.nombre);


        }

    }
}
