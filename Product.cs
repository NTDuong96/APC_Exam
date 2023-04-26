using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    //Abstract base class Product
    internal abstract class Product
    {
        public int productId;
        public string name;
        public double price;
        public string producer;

        //Constructor
        public Product() { 
        
        }

        public Product(int productId, string name, double price, string producer)
        {
            this.productId = productId;
            this.name = name;
            this.price = price;
            this.producer = producer;
        }


        public virtual void input()
        {
            Console.WriteLine("Enter Product ID:");
            this.productId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product's name: ");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter product's price");
            this.price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter producer: ");
            this.producer = Console.ReadLine(); 
        }

        //WriteLine for output
        public virtual void output()
        {
            Console.WriteLine("productId: " + productId + "name: " + name + "price: " + price + "producer: "+ producer);
        }


        //Computing tax
        public abstract double computeTax();


    }
}
