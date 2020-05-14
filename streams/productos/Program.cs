using System;
using System.IO;
using System.Collections.Generic;

namespace productos
{
    class Product
    {
        public Product(string c, string d, Double p){
            Code=c;
            Description=d;
            Price=p;
        }
        public string Code {get; set;}

        public string Description {get; set;}

        public Double Price {get; set;}

    }

    class ProductDB
    {
        public static void WriteToTXT (string path, List <Product> products)
        {
            StreamWriter txtOut = new StreamWriter(
                new FileStream(path, FileMode.Create, FileAccess.Write)); 
            
            foreach(Product p in products){
                txtOut.WriteLine("{0}|{1}|{2}", p.Code, p.Description, p.Price);
            }

            txtOut.Close();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("SDF","Telefono OnePlus 7t", 1234.22));
            products.Add(new Product("SDb","Telefono OnePlus 6t", 1554.22));
            products.Add(new Product("SaF","Telefono OnePlus 8t", 1674.22));
            products.Add(new Product("RDF","Telefono OnePlus 6", 2134.22));
            products.Add(new Product("SDG","Telefono OnePlus 9t", 2235.22));
            
            ProductDB.WriteToTXT(@"C:\Users\axeld\Desktop\AXEL_UNI\productos.txt", products);
        }
    }
}
