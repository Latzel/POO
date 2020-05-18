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

        public Product()
        {

        }
        public string Code {get; set;}

        public string Description {get; set;}

        public Double Price {get; set;}

        public override string ToString(){
            return String.Format("Codigo: {0} Descripcio: {1} Precio: {2}", Code, Description, Price);
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
                txtOut.WriteLine("{0}|{1}|{2}", p.Code, p.Description, p.Price);
            }

            txtOut.Close();
        }

        public static void WriteToBIN (string path, List <Product> products)
        {
            BinaryWriter binOut = new BinaryWriter(
                new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write)); 
            
            foreach(Product p in products)
            {
                binOut.Write(p.Code);
                binOut.Write(p.Description);
                binOut.Write(p.Price);
            }

            binOut.Close();
        }

        public static List<Product> ReadFromTXT(string path)
        {
            List<Product> products = new List<Product>();
            StreamReader txtIn = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));

            while(txtIn.Peek()!=-1)
            {
                string line = txtIn.ReadLine();
                string[] columns = line.Split('|');
                Product p = new Product(columns[0],columns[1], Double.Parse(columns[2]));
                products.Add(p);
            }

            return products;
        }

        public static List<Product> ReadFromBIN(string path)
        {
            List<Product> products = new List<Product>();
            BinaryReader binIn = new BinaryReader(new FileStream(path, FileMode.Open, FileAccess.Read));

            while(binIn.PeekChar()!=-1)
            {

                Product p = new Product();
                p.Code = binIn.ReadString();
                p.Description = binIn.ReadString();
                p.Price = binIn.ReadDouble();
                products.Add(p);
            }

            return products;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            /*
            products.Add(new Product("SDF","Telefono OnePlus 7t", 1234.22));
            products.Add(new Product("SDB","Telefono OnePlus 6t", 1554.22));
            products.Add(new Product("SAF","Telefono OnePlus 8t", 1674.22));
            products.Add(new Product("RDF","Telefono OnePlus 6", 2134.22));
            products.Add(new Product("SDG","Telefono OnePlus 9t", 2235.22));
            */
            //ProductDB.WriteToTXT(@"C:\Users\axeld\Desktop\AXEL_UNI\productos.txt", products);
            //ProductDB.WriteToBIN(@"C:\Users\axeld\Desktop\AXEL_UNI\productos.dat", products);

            //products = ProductDB.ReadFromTXT(@".\productos.txt");
            products = ProductDB.ReadFromBIN(@"C:\Users\axeld\Desktop\AXEL_UNI\productos.dat");

            foreach(Product p in products)
                Console.WriteLine(p);
        }
    }
}
