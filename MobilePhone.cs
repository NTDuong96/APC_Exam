using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    //MobilePhone derived from Product abstract class
    internal class MobilePhone : Product
    {
        public MobilePhone() { 
        
        }

        public MobilePhone(int productId, string name, double price, string producer):base(productId, name, price, producer) { 
        
        }

        public override void input()
        {
            base.input();
        }

        public override void output()
        {
            Console.WriteLine("MobilePhoneId: " + productId + "MobilePhone_name: " + name + "MobilePhone_price: " + price + "MobilePhone_producer: " + producer);
        }

        //MobilePhone tax is 10%
        public override double computeTax()
        {
            return price * 10/100;
        }

    }
}
