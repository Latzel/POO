using System;

namespace Domino
{
    class Ficha //En vez de Espacio1 y Espacio2 use num y den por practicidad
    {
        private int num;
        private int den;

        public Ficha(int numerador, int denominador)//Constructor de fichas
        {
            num=numerador;
            den=denominador;
        }

        public static int operator +(Ficha a, Ficha b){

            return a.num + a.den + b.num + b.den; //Aqui no use un "new algo" porque voy a regresar solo un numero
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Ficha a= new Ficha(3,4);
            Ficha b= new Ficha(4,1);

            Console.WriteLine(a+b);
        }
    }


}