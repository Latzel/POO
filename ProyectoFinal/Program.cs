using System;
using System.IO;
using System.Collections.Generic;

namespace ProyectoFinal
{
    class Product
    {
        public Product(string c, string d, int l){
            Codigo=c;
            Descripcion=d;
            //Precio=p;
            Likes=l;
        }

        public Product()
        {

        }
        public string Codigo {get; set;}

        public string Descripcion {get; set;}

        //public Double Precio {get; set;}

        public int Likes {get; set;}

        public override string ToString(){
            return String.Format("Codigo: {0} Descripcion: {1}  Likes: {2}", Codigo, Descripcion/*, Precio*/, Likes);
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
                txtOut.WriteLine("{0}|{1}|{2}", p.Codigo, p.Descripcion/*, p.Precio*/, p.Likes);
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
                Product p = new Product(columns[0],columns[1]/*, Double.Parse(columns[2])*/, int.Parse(columns[3]));
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
            
            products.Add(new Product("AAA","Telefono OnePlus 5t", 155));
            products.Add(new Product("BBB","Telefono OnePlus 6t", 154));
            products.Add(new Product("CCC","Telefono OnePlus 7t", 153));
            products.Add(new Product("DDD","Telefono OnePlus 8t", 152));
            products.Add(new Product("EEE","Telefono OnePlus 9t", 151));
            
            ProductDB.WriteToTXT(@"C:\Users\axeld\Desktop\productos.txt", products);
    
            //products = ProductDB.ReadFromTXT(@".\productos.txt");

            foreach(Product p in products)
                Console.WriteLine(p);
        }
    }
}
