using System;
using System.Collections.Generic;

namespace ilustrador
{
    interface IFigura
    {
        //Hay que diferenciar las propiedades privadas a las de cada clase
        int X {get; set;}
        int Y {get; set;}

        string Color{get; set;}

        //Cuando pones un metodo en la interfaz se declara como publico en las clases
        void dibuja();

        void ImprimeColor();

    }

    class Circulo : IFigura 
    {

        int x;
        int y;

        string color;

        public Circulo(int x, int y, string c)
        {
            this.x=x;
            this.y=y;
            color=c;

        }

        public int X{ get; set;}

        public int Y{ get; set;}

        public string Color{ get; set;}

        public void dibuja(){
            Console.WriteLine("Se esta trazando un circulo");
        }

        public void ImprimeColor(){
            Console.WriteLine("El circulo es de color {0}",color); //en este caso mandamo a imprimir color con c minuscula porque asi lo declaramos en esta clase
        }

    }

    class Rect : IFigura 
    {
        int x;
        int y;

        string color;

        public Rect(int x, int y, string c)
        {
            this.x=x;
            this.y=y;
            color=c;
        
        }

        public int X{ get; set;}

        public int Y{ get; set;}

        public string Color{ get; set;}

        public void dibuja(){
            Console.WriteLine("Se esta trazando un rectangulo");
        }

        public void ImprimeColor(){
            Console.WriteLine("El rectangulo es de color {0}",color);
        }

    
    }
    
    class Program{
        static void Main(string[] args){
            List<IFigura> figuras = new List<IFigura>();
            figuras.Add(new Circulo(12,13,"verde")) ;
            figuras.Add(new Rect(12,13,"azul")) ;
            figuras.Add(new Rect(12,13,"rojo")) ;
            foreach (var item in figuras){
                item.dibuja();
                item.ImprimeColor();
            }    

            }
        }
}