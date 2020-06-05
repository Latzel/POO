using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoFinal
{
    class Product
    {
        public Product(string c, string d, int dep, int l, Double p){ //Acuerdate de quitar la p
            Codigo=c;
            Descripcion=d;
            Precio=p; //PRECIO ALTERNATIVO AXEL
            Departamento = dep;
            Likes=l;
            
        }
        //lista de precios en otro archivo y que se lea desde aqui?

        public Product()
        {

        }
        public string Codigo {get; set;}

        public string Descripcion {get; set;}

        public Double Precio {get; set;}

        public int Likes {get; set;}

        public int Departamento {get; set;}

        public override string ToString(){
            return String.Format("Codigo: {0} Descripcion: {1}  Dpto: {2} Likes: {3} Precio: {4}", Codigo, Descripcion, Departamento, Likes, Precio); //Precio aqui
        }

        public List<PrecioFecha> Precios = new List<PrecioFecha>();


    }

    class ProductDB
    {
        public static void WriteToTXT (string path, List <Product> products)
        {
            StreamWriter txtOut = new StreamWriter(
                new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write)); 
            
            foreach(Product p in products)
            {
                txtOut.WriteLine("{0}|{1}|{2}|{3}|{4}", p.Codigo, p.Descripcion, p.Departamento, p.Likes, p.Precio);//Precio aqui
            }

            txtOut.Close();

        }

    

        public static List<Product> ReadFromTXT(string path)
        {
            List<Product> products = new List<Product>();
            StreamReader txtIn = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));

            while(txtIn.Peek()!=-1)
            {
                string line = txtIn.ReadLine();
                string[] columns = line.Split('|');
                Product p = new Product(columns[0],columns[1], int.Parse(columns[2]), int.Parse(columns[3]), Double.Parse(columns[4])); //Pecio aqui
                products.Add(p);
            }

            return products;
        }
        
        public static List<Product> ReadFromTXT111(string path)
        {
            List<Product> products = new List<Product>();
            StreamReader txtIn = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));

            while(txtIn.Peek()!=-1)
            {
                string line = txtIn.ReadLine();
                string[] columns = line.Split('|');
                Product p = new Product(columns[0],columns[1], int.Parse(columns[2]), int.Parse(columns[3]), Double.Parse(columns[4])); //Pecio aqui
                products.Add(p);
            }

            return products;
        }


/*
        public static List<Product> GetDepartamento(string depa) //VARIABLE ERROR
        {
           IEnumerable<Product> Producto = from p in products
           where p.Departamento == depa
           select p;
            Console.WriteLine("El producto pertenece al departamento: "+depa);
            
        }    
*/
    
    
    }

    class PrecioFecha //El producto entra con un precio y por dia disminuye 10 pesos hasta bajar 100?
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
            
            products.Add(new Product("AAA","Telefono OnePlus 5t", 2, 155, 1900.99));
            products.Add(new Product("BBB","Telefono OnePlus 6t", 1, 154, 4500.99));
            products.Add(new Product("CCC","Telefono OnePlus 7t", 5, 153, 2300.99));
            products.Add(new Product("DDD","Telefono OnePlus 8t", 2, 152, 2900.99));
            products.Add(new Product("EEE","Telefono OnePlus 9t", 3, 151, 2000.99));
            
            ProductDB.WriteToTXT(@"C:\Users\axeld\Desktop\productos.txt", products);
    
            //products = ProductDB.ReadFromTXT(@".\productos.txt");

            foreach(Product p in products)
                Console.WriteLine(p);
                
            //ProductDB.GetDepartamento(@"C:\Users\axeld\Desktop\productos.txt", products);

            products = ProductDB.ReadFromTXT(@"C:\Users\axeld\Desktop\productos.txt");
            products = ProductDB.ReadFromTXT111(@"C:\Users\axeld\Desktop\productos.txt");

            //Pedir valor que se va a usar para el dpto
            Console.WriteLine("Que departamento deseas buscar?");
            int valor = 0;
            valor = Int16.Parse(Console.ReadLine());

            Console.WriteLine("Los productos dentro del departamento {} son:",valor);

            //foreach(Product p in products)
            //Console.WriteLine(p.Departamento);


        }
    }
}
