using System;

namespace Duracion
{
    class Duracion
    {
        private int horas;
        private int minutos;
        private int segundos;

        public Duracion(int h, int m, int s){
            horas=h;
            minutos=m;
            segundos=s;
        }

        public void imprime(){
            Console.WriteLine("Horas:{0} Minutos:{1} Segundos {2}",horas, minutos, segundos);
        }

        public void Conversiones(){
            minutos=(horas*60)+minutos;
            segundos=(horas*3600)+(minutos*60)+segundos;

            Console.WriteLine("El tiempo en minutos es:"+minutos);
            Console.WriteLine("El tiempo en segundos es:"+segundos);
        }

        public void ConverSeg(){
            int hor;
            int min;

            hor=segundos/3600;
            min=segundos/60;

            Console.WriteLine("La cantidad de segundos en horas  es:"+hor);
            Console.WriteLine("La cantidad de segundos en minutos es:"+min);

        }

        public static Duracion operator +(Duracion a, Duracion b){
            int horas = a.horas+b.horas;
            int minutos = a.minutos+b.minutos;
            int segundos = a.segundos+b.segundos;

            return new Duracion (horas, minutos, segundos);


        }
    }

    class program
    {
        static void Main(string[] args)
        {
            Duracion a= new Duracion(1,15,11);
            Duracion b= new Duracion(0,29,37);
            Duracion c= a+b;


            a.imprime();
            a.Conversiones();
            a.ConverSeg();

            b.imprime();

            c.imprime();


        }
    }

}
