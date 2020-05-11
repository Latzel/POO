using System;

namespace Excepciones //capturaedad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Captura tu edad:");

            int edad = -1;
            bool conexion=true;
            try{
                edad = Int16.Parse(Console.ReadLine());
                edad = edad/0;
                conexion= false;
                
            }
            catch (FormatException fe ){
                Console.WriteLine("Digite unicamente numeros");
                Console.WriteLine(fe.Message);

            }

            catch(OverflowException ){
                Console.WriteLine("Hey! Una edad a 1000 por favor");

            }

            catch (Exception e){
                 Console.WriteLine("Error {0}", e.GetType());
            }

            finally{
                conexion = false;
            }

            if(edad !=-1){
            
            if (edad > 40){
                Console.WriteLine("Estas en riesgo");
            }
            else{
                Console.WriteLine("Riesgo bajo");
            }

            }

            Console.WriteLine(conexion);
        }
    }
}
