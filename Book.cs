using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    //class Book derived from Product abstract class
    internal class Book : Product
    {
        public Book() { 
        
        }
        
        public Book(int productId, string name, double price, string producer): base(productId, name, price, producer) {
        }

        public override void input()
        {
            base.input();
        }

        public override void output() {
            Console.WriteLine("BookId: " + productId + "book_name: " + name + "book_price: " + price + "book_producer: " + producer);
        }

        //Tax of book is 8%
        public override double computeTax()
        {
            return price * 8/100;
        }

    }
}
