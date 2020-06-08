using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace pfprecios
{
    class Product
    {
        public Product(string c, string d, int dep, int l){ //Acuerdate de quitar la p
            Codigo=c;
            Descripcion=d;
            Departamento = dep;
            Likes=l;
            //List<PrecioFecha>  //PRECIO ALTERNATIVO AXEL
            
        }

        public List<PrecioFecha> Precios = new List<PrecioFecha>(); //ListaPrecios por si se hace
        
        public Product()
        {
        }
        public string Codigo {get; set;}

        public string Descripcion {get; set;}

        //public Double Precio {get; set;}

        public int Likes {get; set;}

        public int Departamento {get; set;}

        public override string ToString(){
            return String.Format("Codigo: {0} Descripcion: {1}  Dpto: {2} Likes: {3}", Codigo, Descripcion, Departamento, Likes); //Precio aqui
        }

        public static List<Product> GetDepartamento(int depa, List<Product> products)
        {
            List<Product> RetDepa = new List<Product>();
            foreach(Product p in products)
            {
                if(p.Departamento == depa)
                RetDepa.Add(p);
            }
            return RetDepa;
        }

        public static List<Product> GetPrecio(string prec, List<Product> products) 
        {
            List<Product> RetPrec = new List<Product>();
            foreach(Product p in products)
            {
                if(p.Codigo == prec){
                RetPrec.Add(p);
                }else
                {
                    Console.WriteLine("Error, no existe producto con tal codigo");
                }
            }
            return RetPrec;
        }  
        
    }

    class ProductDB
    {
        public static void WriteToTXT (string path, List <Product> products)
        {
            StreamWriter txtOut = new StreamWriter(
                new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write)); 
            
            foreach(Product p in products)
            {
                txtOut.WriteLine("{0}|{1}|{2}|{3}", p.Codigo, p.Descripcion, p.Departamento, p.Likes);//Precio aqui
            }

            txtOut.Close();

        }
  

        public static List<Product> ReadFromTXT(string path)
        {
            List<Product> products = new List<Product>();
            StreamReader txtIn = new StreamReader(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            while(txtIn.Peek()!=0)
            {
                string line = txtIn.ReadLine();
                string[] columns = line.Split('|');
                Product p = new Product(columns[0],columns[1], int.Parse(columns[2]), int.Parse(columns[3]));
                products.Add(p);
            }

            return products;
        }

    }
    class PrecioFecha
    {
        DateTime FechaInicio{get; set;}
        DateTime FechaFinal{get; set;}
        Decimal Precio{get; set;}
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            
            products.Add(new Product("AAA","Telefono OnePlus 5t", 2, 235));
            products.Add(new Product("BBB","Telefono OnePlus 6t", 1, 2254));
            products.Add(new Product("CCC","Telefono OnePlus 7t", 2, 543));
            products.Add(new Product("DDD","Telefono OnePlus 8t", 3, 562));
            products.Add(new Product("EEE","Telefono OnePlus 9t", 1, 761));
            
            ProductDB.WriteToTXT(@"C:\Users\axeld\Desktop\productos.txt", products);
    
            //products = ProductDB.ReadFromTXT(@".\productos.txt");

            foreach(Product p in products)
                Console.WriteLine(p);
            

            //products = ProductDB.ReadFromTXT(@"C:\Users\axeld\Desktop\productos.txt");

            Console.WriteLine("Que accion deseas realizar? \n 1) Buscar por departamento \n 2) Buscar por medio de codigo \n 3) Ordenar de acuerdo a los likes del producto");
            try{
                int caseSwitch = Int16.Parse(Console.ReadLine());
        
            switch(caseSwitch)
            {
                case 1: //Caso donde se obtienen los productos de cada departamento
                try{
            Console.WriteLine("Que departamento deseas buscar? \n 1)Telefonos \n 2)Computadoras \n 3)Televisores");
            List<Product> val = Product.GetDepartamento(Int16.Parse(Console.ReadLine()), products);
            Console.WriteLine("Los productos dentro de ese departamento departamento son: ");
            foreach(Product p in val)  
            Console.WriteLine(p);
                }//Numero diferente a 1,2,3
                catch (FormatException fe ){
                Console.WriteLine("Digite unicamente numeros (Procurre que sean enteros)");
                Console.WriteLine(fe.Message);
            }

            catch (OverflowException ov ){
                Console.WriteLine("Utilice unicamente la cantidad necesaria de digitos");
                Console.WriteLine(ov.Message);
            }

            catch (Exception){
                Console.WriteLine("Epale, como le hiciste para equivocarte tan machin?");
            }
            break;

                case 2: //Caso donde se obtien el precio de cada prouducto
                try{
            Console.WriteLine("Por favor añada el codigo del producto el cual desea conocer su precio");
            /*
            List<Product> cod = Product.GetPrecio(Console.ReadLine(), products);
            Console.WriteLine("El precio de su producto es de: ");
            foreach(Product p in cod)
            Console.WriteLine("El precio del producto {0}-{1} es de: {2}$",p.Codigo, p.Descripcion, p.Precio);
                }//Codigo de 3 letras "XXX"
                catch (FormatException fe ){
                Console.WriteLine("Digite unicamente numeros (Procurre que sean enteros)");
                Console.WriteLine(fe.Message);
                */
            }

            catch (OverflowException ov ){
                Console.WriteLine("Utilice unicamente la cantidad necesaria de digitos");
                Console.WriteLine(ov.Message);
            } 
            break;     

                case 3:

           Console.WriteLine("Los siguientes productos estan acomodados de menor a mayor:");
            var ordena = products.OrderBy(x => x.Likes);
            foreach(Product p in ordena)
                Console.WriteLine(p);
            
            break;

            }

             }catch (FormatException fe ){
                Console.WriteLine("Digite unicamente numeros (Procurre que sean enteros)");
                Console.WriteLine(fe.Message);
            }

            catch (OverflowException ov ){
                Console.WriteLine("Utilice unicamente la cantidad necesaria de digitos");
                Console.WriteLine(ov.Message);
            }

            catch (Exception){
                Console.WriteLine("Epale, como le hiciste para equivocarte tan machin?");
            }
        }
    }

}